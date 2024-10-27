using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelTour.Model;

namespace TravelTour.View
{
    public partial class Guide : Form
    {
        private UserAccountModel currentUser;

        public Guide(UserAccountModel user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage(currentUser);
            home.ShowDialog();
            this.Close();
        }
    }
}
