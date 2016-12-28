using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysql
{

    public partial class Form1 : Form
    {
        public static MySqlConnection connection;
        public static Panel p1;

        public Form1()
        {
            InitializeComponent();
            //loginBox.Enabled = false;
            //passwordBox.Enabled = false;
            //LogInButton.Enabled = false;
            //Connect_button.Hide();
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            
            string cs = "server=sql.freshwebsite.nazwa.pl;userid=freshwebsite_2;password=Projekt123;database=freshwebsite_2";
            Form1.connection = new MySqlConnection(cs);
            try
            {
                Form1.connection.Open();
                loginBox.Enabled = true;
                passwordBox.Enabled = true;
                LogInButton.Enabled = true;
                //Connect_button.Hide();
                MessageBox.Show("Połączono","Gratulacje");
                Form1.p1 = new Panel();
                Form1.p1.ShowDialog();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void find_administrator(string login, string password)
        {
            string temp;
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrator WHERE login='"+login+"';", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    
                    
                        temp = rdr.GetString(2);
                        if (temp != password) MessageBox.Show("Błędne hasło!");
                        else {
                            MessageBox.Show("Witam " + login,"Zalogowano");
                        //this.Visible=false; //nie widać wtedy Form1 przydałoby się żeby wykryło kiedy zamknę p1
                        //tutaj przejscie do panelu sterowania ->Panel.cs
                        rdr.Close();
                        passwordBox.Text = "";
                            Form1.p1 = new Panel();
                            Form1.p1.ShowDialog();
                        }
                        
                    
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR");
            }
            catch (Exception)
            {
                MessageBox.Show("Coś poszło nie tak!","ERROR");
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string cs = "server=sql.freshwebsite.nazwa.pl;userid=freshwebsite_2;password=Projekt123;database=freshwebsite_2";
            Form1.connection = new MySqlConnection(cs);
            if (loginBox.Text == "" || passwordBox.Text == "") MessageBox.Show("Podaj login oraz hasło administratora");
            else {
                try
                {
                    Form1.connection.Open();
                    string login = loginBox.Text;
                    string password = passwordBox.Text;
                    find_administrator(login, password);
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR!");
                }
            }
        }

        private void backgroundForm1_DoWork(object sender, DoWorkEventArgs e)
        {
            //nie dziala?
            if (connection.State == ConnectionState.Closed) Connect_button.Show();
        }
    }
}
