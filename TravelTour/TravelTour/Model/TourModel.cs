using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    public class TourModel : IModel
    {
        public int IDtour { get; set; }
        public int ID { get; set; }
        public int IDtv { get; set; }
        public DateTime BookingDate { get; set; }
        public int Quantity { get; set; }

        public TourModel()
        {
            IDtour = 0;
            ID = 0;
            IDtv = 0;
            BookingDate = DateTime.Now;
            Quantity = 0;
        }

        public TourModel(int idTour, int id, int idTv, DateTime bookingDate, int quantity)
        {
            this.IDtour = idTour;
            this.ID = id;
            this.IDtv = idTv;
            this.BookingDate = bookingDate;
            this.Quantity = quantity;
        }
    }
}
