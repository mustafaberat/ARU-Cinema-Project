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
    public partial class addSalon : Form
    {
        public string conString = "Data Source=DESKTOP-ASUS\\SQLEXPRESS;Initial Catalog=VeriTabt_CinemaProject;Integrated Security=True";
        public void getSalon()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Name,Capasity,Floor FROM Salon";
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
        public addSalon()
        {
            InitializeComponent();
            getSalon();
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addSalon addSalon = new addSalon();
            this.Hide();
            addSalon.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string salonName = textBox2.Text.ToString();
                    decimal capasity = numericUpDownCapasity.Value;
                    decimal floor = numericUpDownFloor.Value;
                    if (salonName == "")
                    {
                        MessageBox.Show("Check salon name please", "Salon Name Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Random rnd = new Random();
                        int randomNo1000to9000 = rnd.Next(1000, 9000);
                        string query = "INSERT INTO Salon (SalonID, SeatID,Name,Capasity,Floor) VALUES ('" + randomNo1000to9000 + "','" + 47 + "','" + salonName + "','" + capasity + "','" + floor+ "')";
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

    }
}
