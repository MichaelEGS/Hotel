using Datos.Models;
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


namespace Hotel
{
    public partial class AgregarReservacion : Form
    {
        private ServicioDeReserva servicioDeReserva;
        public AgregarReservacion()
        {
            InitializeComponent();
            servicioDeReserva = new ServicioDeReserva();
            LoadAvailableRooms();
           
        }
        
        
        private void LoadAvailableRooms()
        {
            var availableRooms = servicioDeReserva.ObtenerHabitacionesDisponibles();
            cbHabitacion.DataSource = availableRooms;
            cbHabitacion.DisplayMember = "NumeroHabitacion";
            cbHabitacion.ValueMember = "IdHabitacion";
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbHabitacion.SelectedItem != null && !string.IsNullOrWhiteSpace(TxtNombreH.Text))
            {
                var nuevaReservacion = new Reservacion
                //Reservacion newReservation = new Reservacion
                {
                NombreHuesped = TxtNombreH.Text,
                CheckInDate = dateTimeCheckin.Value,
                CheckOutDate = dateTimeCheckout.Value,
                IdHabitacion = (int)cbHabitacion.SelectedValue
            };
                try
                {
                    servicioDeReserva.AgregarReservacion(nuevaReservacion);
                    MessageBox.Show("Reservación agregada exitosamente.");
                    LoadAvailableRooms();
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al agregar la reservación: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

        }


        private void txtNombreHuesped_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            TxtNombreH.Clear();
            dateTimeCheckin.Value = DateTime.Now;
            dateTimeCheckout.Value = DateTime.Now;
            cbHabitacion.SelectedIndex = -1;
        }
    }

}
