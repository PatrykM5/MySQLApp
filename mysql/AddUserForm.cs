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
    public partial class AddUserForm : Form
    {
        public bool added = false;
        public AddUserForm()
        {
            InitializeComponent();
            //UserNameBox.Enabled = false;
            //UserSurnameBox.Enabled = false;
            //UserMailBox.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddUser()
        {
            string login = "", password = "", name = "", surname = "", email = "";
            if (UserLoginBox.Text == "" || UserPassBox.Text == "" || UserMailBox.Text == "" || UserNameBox.Text == "" || UserSurnameBox.Text == "")
            {
                MessageBox.Show("Dodanie użytkownika wymaga podania nazwy, hasła, imienia, nazwiska, email!", "Błąd");
            }
            else
            {
                try
                {
                    login = UserLoginBox.Text;
                    password = UserPassBox.Text;
                    name = UserNameBox.Text;
                    surname = UserSurnameBox.Text;
                    email = UserMailBox.Text;
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login='" + UserLoginBox.Text + "' OR email='" + UserMailBox.Text + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read()) MessageBox.Show("Użytkownik o tym loginie lub emailu już istnieje!", "Błąd");
                    else
                    {
                        //tutaj zapytanie dodajace uzytkownika
                        rdr.Close();
                        string insert_query = "INSERT INTO uzytkownik (login,haslo,stan_konta,stat,imie,nazwisko,email) VALUES ('" + login + "','" + password + "','0','Nieaktywny', '" + name + "', '" + surname + "', '" + email + "')";
                        MySqlCommand updateCmd = new MySqlCommand(insert_query, Form1.connection);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Dodano użytkownika " + login, "Gratulacje");
                        added = true;
                    }
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            AddUser();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
