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
            Name = string.Empty;
            ImageUrl = string.Empty;
            Date = DateTime.MinValue;
            Location = string.Empty;
            Sex = string.Empty;
            Age = 0;
        }
        
        public InforModel(int id, string name, string imageUrl, DateTime date, string location, string sex, int age)
        {
            this.ID = id;
            this.Name = name;
            this.ImageUrl = imageUrl;
            this.Date = date;
            this.Location = location;
            this.Sex = sex;
            this.Age = age;
        }
    }
}
