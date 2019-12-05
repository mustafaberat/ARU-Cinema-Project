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
    public partial class ManagerPage : Form
    {
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void goBackHome_Click(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();
            this.Hide();
            firstPage.ShowDialog();
        }

        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            addDirectorPage addDirectorPage1 = new addDirectorPage();
            addDirectorPage1.ShowDialog();
        }

        private void addFilmButton_Click(object sender, EventArgs e)
        {
            addFilmPage addFilmPage = new addFilmPage();
            addFilmPage.ShowDialog();
        }

        private void addSalonButton_Click(object sender, EventArgs e)
        {
            addSalon goingToNextPageObj = new addSalon();
            goingToNextPageObj.ShowDialog();
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            addPosition goingToNextPageObj = new addPosition();
            goingToNextPageObj.ShowDialog();
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            addWorker goingToNextPageObj = new addWorker();
            goingToNextPageObj.ShowDialog();
        }

        private void AddFilmLanguageButton_Click(object sender, EventArgs e)
        {
            addFilmLanguage goingToNextPageObj = new addFilmLanguage();
            goingToNextPageObj.ShowDialog();
        }
    }
}
