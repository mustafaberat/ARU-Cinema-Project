using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_CinemaProject
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show("Nothing");
            LogInManager goingLogIn = new LogInManager();
            goingLogIn.ShowDialog();

        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            HelloIamEmployee h1 = new HelloIamEmployee();
            this.Hide();
            h1.ShowDialog();
        }
    }
}
