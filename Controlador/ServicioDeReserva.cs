using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelos.EF;
using System.Data.Entity;

namespace Datos.Models
{
    public class ServicioDeReserva
    {
        private HotelDBEntities _context;

        public ServicioDeReserva()
        {
            _context = new HotelDBEntities();

        }

        public List<Habitacion> ObtenerHabitacionesDisponibles()
        {

            return _context.Habitaciones.Where(h => h.IsAvailable).ToList();
        }

        public void AgregarReservacion(Reservacion reservacion)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try

                {
                    _context.Reservaciones.Add(reservacion);
                    var habitacion = _context.Habitaciones.Find(reservacion.IdHabitacion);
                    habitacion.IsAvailable = false;
                    _context.SaveChanges();
                    transaction.Commit();       
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;

                }
            }
        }
        public List<Reservacion> ObtenerTodasLasReservaciones()
        {

            return _context.Reservaciones.Include("Habitacion").ToList();

        }

        public Reservacion ObtenerReservacionPorId(int id)
        {
            return _context.Reservaciones.Include(r => r.Habitacion).FirstOrDefault(r => r.IdReservacion == id);
        }

        public List<Reservacion> ObtenerReservacionesPorNombre(string nombreHuesped)
        {
            return _context.Reservaciones
                           .Include(r => r.Habitacion)
                           .Where(r => r.NombreHuesped.Contains(nombreHuesped))
                           .ToList();
        }

        public void ActualizarReservacion(Reservacion reservacion)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var reservacionExistente = _context.Reservaciones.Find(reservacion.IdReservacion);
                    if (reservacionExistente != null)
                    {
                        var habitacionAntigua = _context.Habitaciones.Find(reservacionExistente.IdHabitacion);
                        habitacionAntigua.IsAvailable = true;

                        reservacionExistente.NombreHuesped = reservacion.NombreHuesped;
                        reservacionExistente.CheckInDate = reservacion.CheckInDate;
                        reservacionExistente.CheckOutDate = reservacion.CheckOutDate;
                        reservacionExistente.IdHabitacion = reservacion.IdHabitacion;

                        var habitacionNueva = _context.Habitaciones.Find(reservacion.IdHabitacion);
                        habitacionNueva.IsAvailable = false;

                        _context.SaveChanges();
                        transaction.Commit();
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void EliminarReservacion(int id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var reservacion = _context.Reservaciones.Find(id);
                    if (reservacion != null)
                    {
                        var habitacion = _context.Habitaciones.Find(reservacion.IdHabitacion);
                        habitacion.IsAvailable = true;
                        _context.Reservaciones.Remove(reservacion);
                        _context.SaveChanges();
                        transaction.Commit();
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

    }
}


