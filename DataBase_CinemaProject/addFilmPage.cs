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
    public partial class addFilmPage : Form
    {
        public string conString = "Data Source=DESKTOP-ASUS\\SQLEXPRESS;Initial Catalog=VeriTabt_CinemaProject;Integrated Security=True";
        public int findLanguage(string givenLanguage)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT LanguageID FROM FilmLanguage WHERE Name = ('" + givenLanguage + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if(sqlDataReader.Read())
                    {
                        string number = (sqlDataReader["LanguageID"].ToString());
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
        public int findFilmType(string givenType)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT TypeID FROM FilmType WHERE Name = ('" + givenType + "')";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        string number = (sqlDataReader["TypeID"].ToString());
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
        public int findDirectorID(string givenName)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT DirectorID FROM Director WHERE Name = ('" + givenName +"')";
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        string number=(sqlDataReader["DirectorID"].ToString());
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
        public void getFilmsToSee()
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Film.Name FilmName,FilmLanguage.Name Language,FilmType.Name FilmType, Director.Name DirectorName, Lenght, Rate,Description,ReleaseYear FROM Film,FilmLanguage,Director,FilmType WHERE " +
                        "Film.DirectorID = Director.DirectorID AND Film.LanguageID = FilmLanguage.LanguageID AND Film.TypeID = FilmType.TypeID" ;
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
        public void getLanguages()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT Name FROM FilmLanguage ";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox3.Items.Add(sqlDataReader.GetString(0));
                }
            }
            else
            {
                MessageBox.Show("Couldnt connect database");
            }
            con.Close();
        }
        public void getDirectors()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT Name FROM Director ";
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
        public void getFilmTypes()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT Name FROM FilmType ";
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
        public addFilmPage()
        {
            InitializeComponent();
            getFilmsToSee();
            getDirectors();
            getLanguages();
            getFilmTypes();
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addFilmPage addFilmPage = new addFilmPage();
            addFilmPage.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addFilmButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int randomNo1000to9000 = rnd.Next(1000, 9000);
                string filmName = textBox2.Text.ToString();
                string iDate = textBox1.Text.ToString();
                DateTime oDate = DateTime.ParseExact(iDate, "yyyy-MM-dd", null);
                //MessageBox.Show("Odate: "+oDate.ToString());
                decimal mylenght = numericUpDown2.Value;
                decimal rate = numericUpDown1.Value;
                string description = richTextBox1.Text.ToString();
                string directorName = comboBox1.Text.ToString();
                string filmType = comboBox2.Text.ToString();
                string language = comboBox3.Text.ToString();
                if (findDirectorID(directorName.ToString()) != 0 && findLanguage(language.ToString()) != 0 && findFilmType(filmType.ToString()) != 0 && rate >= 0 && rate <= 10 && filmName.Length > 0 && description.Length > 0)
                { //Correct informations
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string query = "INSERT INTO Film (FilmID, TypeID, LanguageID,DirectorID,ReleaseYear,Name,Description,Lenght,Rate) VALUES " +
                            "('" + randomNo1000to9000 + "','" + findFilmType(filmType.ToString()) + "', '"+ findLanguage(language.ToString()) + "', '" + findDirectorID(directorName.ToString()) + "', '" + iDate + "', '" + filmName + "', '" + description + "', '" + mylenght + "', '" + rate + "')";
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
