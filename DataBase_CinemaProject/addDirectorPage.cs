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
    public partial class addDirectorPage : Form
    {
        public string conString = "Data Source=DESKTOP-ASUS\\SQLEXPRESS;Initial Catalog=VeriTabt_CinemaProject;Integrated Security=True";

        public void getDirectors()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Name FROM Director";
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
                    MessageBox.Show("Check your database please", "Data Base Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public addDirectorPage()
        {
            InitializeComponent();
            getDirectors();
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string directorName = textBox1.Text.ToString();
                    if(directorName == "")
                    {
                    MessageBox.Show("Check director name please", "Director Name Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                    Random rnd = new Random();
                    int randomNo1000to9000 = rnd.Next(1000, 9000);
                    string query = "INSERT INTO Director (DirectorID, Name) VALUES ('" + randomNo1000to9000 + "','" + directorName + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    MessageBox.Show("Successfully added", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Couldnt connect database");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDirectorPage addDirectorPage= new addDirectorPage();
            this.Hide();
            addDirectorPage.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
