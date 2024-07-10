using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.ViewModels
{
    public class DvgView
    {
        public class ReservacionView
        {
            public int IdReservacion { get; set; }
            public string NombreHuesped { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public string NumeroHabitacion { get; set; }
        }
    }
}
