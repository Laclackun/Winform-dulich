using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    public class TravelModel : IModel
    {
        public int IDtv { get; set; }
        public string Nametv { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string TypeTv { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }

        public TravelModel()
        {
            IDtv = 0;
            Nametv = string.Empty;
            DateStart = DateTime.Now;
            DateEnd = DateTime.Now;
            Description = string.Empty;
            Location = string.Empty;
            TypeTv = string.Empty;
            ImageUrl = string.Empty;
            Quantity = 0;
        }

        public TravelModel(int id, string name, DateTime startDate, DateTime endDate, string description, string location, string type, string imageUrl, int quantity)
        {
            this.IDtv = id;
            this.Nametv = name;
            this.DateStart = startDate;
            this.DateEnd = endDate;
            this.Description = description;
            this.Location = location;
            this.TypeTv = type;
            this.ImageUrl = imageUrl;
            this.Quantity = quantity;
        }
    }
}
