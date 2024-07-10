using Datos.Models;
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
    public partial class Eliminar_Reserva : Form
    {
        private ServicioDeReserva servicioDeReserva;
        public Eliminar_Reserva()
        {
            InitializeComponent();
            servicioDeReserva = new ServicioDeReserva();
            BtnEliminarR.Enabled = false;
            dgvDelete.SelectionChanged += dgvDelete_SelectionChanged;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            {
                string nombreHuesped = txtBuscarDelete.Text;
                if (!string.IsNullOrEmpty(nombreHuesped))
                {
                    var reservaciones = servicioDeReserva.ObtenerReservacionesPorNombre(nombreHuesped);
                    if (reservaciones.Any())
                    {
                        var reservacionViews = reservaciones.Select(r => new ReservacionView
                        {
                            IdReservacion = r.IdReservacion,
                            NombreHuesped = r.NombreHuesped,
                            CheckInDate = r.CheckInDate,
                            CheckOutDate = r.CheckOutDate,
                            NumeroHabitacion = r.Habitacion.NumeroHabitacion
                        }).ToList();

                        dgvDelete.DataSource = reservacionViews;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron reservaciones para el huésped especificado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido.");
                }
            }   }

            private int? reservacionSeleccionadaId = null;

        private void dgvDelete_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDelete.SelectedRows.Count > 0)
            {
                var row = dgvDelete.SelectedRows[0];
                reservacionSeleccionadaId = (int)row.Cells["IdReservacion"].Value;
                BtnEliminarR.Enabled = true;
            }
            else
            {
                reservacionSeleccionadaId = null;
                BtnEliminarR.Enabled = false;
            }
        }
        private void BtnEliminarR_Click(object sender, EventArgs e)
        {
            {
                if (reservacionSeleccionadaId.HasValue)
                {
                    servicioDeReserva.EliminarReservacion(reservacionSeleccionadaId.Value);
                    MessageBox.Show("Reservación eliminada exitosamente.");
                    reservacionSeleccionadaId = null;
                    BtnEliminarR.Enabled = false;
                    txtBuscarDelete.Clear();
                    dgvDelete.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una reservación para eliminar.");
                }
            }
        }
}   }
