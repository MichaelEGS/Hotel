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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reservacion newReservation = new Reservacion
            {
                NombreHuesped = TxtNombreH.Text,
                CheckInDate = dateTimeCheckin.Value,
                CheckOutDate = dateTimeCheckout.Value,
                IdHabitacion = (int)cbHabitacion.SelectedValue
            };

            servicioDeReserva.AgregarReservacion(newReservation);
            MessageBox.Show("Reservación agregada exitosamente.");  
            this.Close();
        }
    }
}
