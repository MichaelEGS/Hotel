using Datos.Models;
using Hotel.ViewModels;
using Modelos.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hotel.ViewModels.DvgView;

namespace Hotel
{
    public partial class Actualizar__Reserva : Form
    {
        private ServicioDeReserva servicioDeReserva;
        private int? reservacionSeleccionadaId = null;

        public Actualizar__Reserva()
        {
            InitializeComponent();
            servicioDeReserva = new ServicioDeReserva();
            dgvReservas.SelectionChanged += dgvReservas_SelectionChanged;
            LoadAllReservaciones();
            LoadAvailableRooms();
            ActualizarcbHabitacion.Enabled = false; // Desactivar el ComboBox por defecto
        }
        private void LoadAllReservaciones()
        {
            var reservaciones = servicioDeReserva.ObtenerTodasLasReservaciones();
            var reservacionViews = reservaciones.Select(r => new ReservacionView
            {
                IdReservacion = r.IdReservacion,     
                NombreHuesped = r.NombreHuesped,
                CheckInDate = r.CheckInDate,
                CheckOutDate = r.CheckOutDate,
                NumeroHabitacion = r.Habitacion.NumeroHabitacion
            }).ToList();

            dgvReservas.DataSource = reservacionViews;
        }

        private void LoadAvailableRooms()
        {
            var availableRooms = servicioDeReserva.ObtenerHabitacionesDisponibles();
            ActualizarcbHabitacion.DataSource = availableRooms;
            ActualizarcbHabitacion.DisplayMember = "NumeroHabitacion";
            ActualizarcbHabitacion.ValueMember = "IdHabitacion";
        }
        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                var row = dgvReservas.SelectedRows[0];
                reservacionSeleccionadaId = (int)row.Cells["IdReservacion"].Value;
                var reservacion = servicioDeReserva.ObtenerReservacionPorId(reservacionSeleccionadaId.Value);

                if (reservacion != null)
                {
                    TxtActualizarNombre.Text = reservacion.NombreHuesped;
                    ActualizarTimeCheckin.Value = reservacion.CheckInDate;
                    ActualizarTimeCheckout.Value = reservacion.CheckOutDate;
                    ActualizarcbHabitacion.SelectedValue = reservacion.IdHabitacion;
                    ActualizarbtnGuardar.Enabled = true;

                    var availableRooms = servicioDeReserva.ObtenerHabitacionesDisponibles();
                    ActualizarcbHabitacion.DataSource = availableRooms;
                    ActualizarcbHabitacion.DisplayMember = "NumeroHabitacion";
                    ActualizarcbHabitacion.ValueMember = "IdHabitacion";


                    ActualizarcbHabitacion.SelectedValue = reservacion.IdHabitacion;
                    ActualizarcbHabitacion.Enabled = true; // Activar el ComboBox cuando se selecciona una reserva
                    ActualizarbtnGuardar.Enabled = true;


                }
                else
                {
                    reservacionSeleccionadaId = null;
                    ActualizarbtnGuardar.Enabled = false;
                }
            }


        }
            private void ActualizarbtnGuardar_Click(object sender, EventArgs e)
            {
                if (reservacionSeleccionadaId.HasValue)
                {
                    var reservacion = new Reservacion
                    {
                        IdReservacion = reservacionSeleccionadaId.Value,
                        NombreHuesped = TxtActualizarNombre.Text,
                        CheckInDate = ActualizarTimeCheckin.Value,
                        CheckOutDate = ActualizarTimeCheckout.Value,
                        IdHabitacion = (int)ActualizarcbHabitacion.SelectedValue
                    };

                    servicioDeReserva.ActualizarReservacion(reservacion);
                    MessageBox.Show("Reservación actualizada exitosamente.");
                    LoadAllReservaciones(); // Refrescar las reservaciones
                    ActualizarcbHabitacion.Enabled = false; // Desactivar el ComboBox después de guardar
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una reservación para actualizar.");
                }
            }
    }   }
