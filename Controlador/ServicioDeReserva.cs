using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelos.EF;

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

        public void ActualizarReservacion(Reservacion reservacion)
        {
            var reservacionExistente = _context.Reservaciones.Find(reservacion.IdReservacion);
            if (reservacionExistente != null)
            {
                reservacionExistente.NombreHuesped = reservacion.NombreHuesped;
                reservacionExistente.CheckInDate = reservacion.CheckInDate;
                reservacionExistente.CheckOutDate = reservacion.CheckOutDate;
                reservacionExistente.IdHabitacion = reservacion.IdHabitacion;

                var habitacion = _context.Habitaciones.Find(reservacionExistente.IdHabitacion);
                habitacion.IsAvailable = false;

                _context.SaveChanges();
            }

        }

        public void EliminarReservacion(int id)
        {
            var reservacion = _context.Reservaciones.Find(id);
            if (reservacion != null)
            {
                _context.Reservaciones.Remove(reservacion);
                var habitacion = _context.Habitaciones.Find(reservacion.IdHabitacion);
                habitacion.IsAvailable = true;
                _context.SaveChanges();
            }
        }
    }


}


