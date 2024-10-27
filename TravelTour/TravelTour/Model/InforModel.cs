using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    public class InforModel : IModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public InforModel()
        {
            ID = 0;
            Name = "";
            ImageUrl = "";
            Date = DateTime.MinValue;
            Location = "";
            Sex = "";
            Age = 0;
        }
    }
}
