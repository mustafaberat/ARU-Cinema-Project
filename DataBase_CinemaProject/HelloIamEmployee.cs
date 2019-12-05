using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DataBase_CinemaProject
{
    public partial class HelloIamEmployee : Form
    {

        public HelloIamEmployee()
        {
            InitializeComponent();
        }

        private void goShoppingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment goPay = new Payment();
            goPay.ShowDialog();
        }

        private void lookfilms_Click(object sender, EventArgs e)
        {
            LookAtFilms lookAtFilms = new LookAtFilms();
            lookAtFilms.ShowDialog();
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }
    }
}
