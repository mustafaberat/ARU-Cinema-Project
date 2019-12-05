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
    public partial class LogInManager : Form
    {
        public LogInManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            string myusername = usernameTextBox.Text;
            string mypassword = passwordTextBox.Text;
            if(myusername == "mustafaberat" && mypassword == "mustafaberat")
            { // Correct
                ManagerPage managerPage = new ManagerPage();
                this.Hide();
                managerPage.ShowDialog();
            }
            else
            { //False
                MessageBox.Show("Check your informations", "Wrong Answers",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage goingFirstPage = new FirstPage();
            goingFirstPage.ShowDialog();
        }
    }
}
