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
    public partial class LookAtFilms : Form
    {

        public string conString = "Data Source=DESKTOP-ASUS\\SQLEXPRESS;Initial Catalog=VeriTabt_CinemaProject;Integrated Security=True";

        public void getFilms()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Film.Name FilmName,FilmLanguage.Name Language, Director.Name DirectorName, Lenght, Rate,Description,ReleaseYear FROM Film,FilmLanguage,Director WHERE " +
                        "Film.DirectorID = Director.DirectorID AND Film.LanguageID = FilmLanguage.LanguageID";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(sqlDataReader);
                        sqlDataReader.Close();
                        con.Close();
                        dataGridView1.DataSource = dataTable;
                    }

                }
                else
                {
                    MessageBox.Show("Couldnt connect database");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public LookAtFilms()
        {
            InitializeComponent();
            getFilms();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
