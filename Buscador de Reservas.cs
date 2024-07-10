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
    public partial class Buscador_de_Reservas : Form    

    {
        private ServicioDeReserva servicioDeReserva;
        public Buscador_de_Reservas()
        {
            InitializeComponent();
            servicioDeReserva = new ServicioDeReserva();
        }
     
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombreHuesped = txtBuscarHp.Text;
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

                    dgvSearch.DataSource = reservacionViews;
                    //dgvSearch.DataSource = reservaciones;
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

            //int id;
            //if (int.TryParse(txtBuscarHp.Text, out id))
            //{
            //    var reservacion = servicioDeReserva.ObtenerReservacionPorId(id);
            //    if (reservacion != null)
            //    {
            //        dgvSearch.DataSource = new[] { reservacion }.ToList();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Reservación no encontrada.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, ingrese un ID válido.");
            //}

        }
    }
}
