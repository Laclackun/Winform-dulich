using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    public class UserAccountModel : IModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public UserAccountModel()
        {
            ID = 0;
            Username = "";
            Password = "";
            Role = "";
        }

        public UserAccountModel(int id, string username, string password, string role)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
