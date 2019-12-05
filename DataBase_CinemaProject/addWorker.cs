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
    public partial class addWorker : Form
    {
        public string conString = "Data Source=DESKTOP-ASUS\\SQLEXPRESS;Initial Catalog=VeriTabt_CinemaProject;Integrated Security=True";
        public void getTitlesToCheckBox()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT Name FROM Title";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox1.Items.Add(sqlDataReader.GetString(0));
                }

            }
            else
            {
                MessageBox.Show("Couldnt connect database");
            }
            con.Close();
        }
        public void getWorkersToGridView()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Worker.Name WorkerName,Surname,Email,Phone,StartDate,Title.Name Position FROM Worker,Title WHERE " +
                        "Title.TitleID = Worker.TitleID";
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
        public addWorker()
        {
            InitializeComponent();
            getTitlesToCheckBox();
            getWorkersToGridView();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            addWorker addW = new addWorker();
            this.Hide();
            addW.ShowDialog();
        }
        public int findPosition(string position)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT TitleID FROM Title WHERE Name = ('" + position + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        string number = (sqlDataReader["TitleID"].ToString());
                        return System.Convert.ToInt32(number);
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
            return 0;
        }
        private void addFilmButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int randomNo1000to9000 = rnd.Next(1000, 9000);
                string name = textBox2.Text.ToString();
                string surname = textBox3.Text.ToString();
                string iDate = textBox1.Text.ToString();
                string email = textBox4.Text.ToString();
                string phone = textBox5.Text.ToString();
                DateTime oDate = DateTime.ParseExact(iDate, "yyyy-MM-dd", null);
                string position = comboBox1.Text.ToString();

                if (findPosition(position.ToString()) != 0 && name.Length>0 && surname.Length>0 && iDate.Length>0 && position.Length>0)
                { //Correct informations
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string query = "INSERT INTO Worker (WorkerID, AdressID,TitleID, Name,Surname,Email,Phone,StartDate) VALUES " +
                            "('" + randomNo1000to9000 + "','" + 45 + "','" + findPosition(position.ToString()) + "', '" + name + "', '" + surname + "', '" + email + "', '" + phone + "', '" + iDate+ "')";
                        SqlCommand sqlCommand = new SqlCommand(query, con);
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        MessageBox.Show("Successfully added", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Couldnt connect database");
                    }
                    con.Close();


                }
                else
                { //Wrong informations
                    MessageBox.Show("Please check your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
