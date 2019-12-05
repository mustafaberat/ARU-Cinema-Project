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
    public partial class Payment : Form
    {
        public string conString = "Data Source=DESKTOP-ASUS\\SQLEXPRESS;Initial Catalog=VeriTabt_CinemaProject;Integrated Security=True";
        public void saveCustomer()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string tc = textBox6.Text.ToString();
                    if (tc != "" && textBox1.Text.ToString() != "" && textBox3.Text.ToString() != "" && textBox4.Text.ToString() != "" && textBox5.Text.ToString() != "" && textBox2.Text.ToString() != "")
                    {
                        string query = "INSERT INTO Customer (CustomerID, Name,Surname,Email,Phone) VALUES ('" + Convert.ToInt32(tc) + "','" + textBox1.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')";
                        SqlCommand sqlCommand = new SqlCommand(query, con);
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        MessageBox.Show("Thank you for shopping. Your ticket sent your email and phone. Have a good watch.", "Successfully Get It", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please check your information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        public void saveCardNo()
        {
            string cardNo = textBox2.Text.ToString();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (cardNo.ToString() == "")
                {
                    Random rnd = new Random();
                    int randomNo1000to9000 = rnd.Next(1000, 9000);
                    string query = "INSERT INTO Fee (FeeID, FeeTypeID,CardNo) VALUES ('"+ randomNo1000to9000 + "','" +2 +"','" +cardNo +"')";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                }
            }
            else
            {
                MessageBox.Show("Couldnt connect database");
            }
            con.Close();
        }
        public void getFilmsToOptions()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT Name FROM Film ";
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
        public void getSalonsToOptions()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT Name FROM Salon ";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox2.Items.Add(sqlDataReader.GetString(0));
                }


            }
            else
            {
                MessageBox.Show("Couldnt connect database");
            }
            con.Close();
        }
        public void getAllInfosToGridView()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Film.Name FilmName,FilmLanguage.Name Language, Director.Name DirectorName, Lenght, Rate,Description,ReleaseYear,Salon.Name SalonName,Salon.Capasity, Salon.Floor FROM Payment,Salon,Film,FilmLanguage,Director WHERE " +
                        "Film.DirectorID = Director.DirectorID" +
                        " AND Film.LanguageID = FilmLanguage.LanguageID" +
                        " AND Salon.SalonID = Payment.SalonID";
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
        public Payment()
        {
            InitializeComponent();
            getFilmsToOptions();
            getSalonsToOptions();
            getAllInfosToGridView();
        }


        private void goShoppingButton_Click(object sender, EventArgs e)
        {
            saveCardNo();
            saveCustomer();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();
            this.Hide();
            firstPage.ShowDialog();
        }

    }
}
