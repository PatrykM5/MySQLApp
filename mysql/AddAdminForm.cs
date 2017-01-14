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
    public partial class AddAdminForm : Form
    {
        private int id=0;
        private string login="";
        private string password = "";
        private string type_name = "";
        private int choice = 0;
        private bool b_login = false, b_pass = false, b_type = false;
        public bool added = false, edited = false;
        public AddAdminForm(string formname,int id_n)
        {
            InitializeComponent();
            this.Text = formname;
            if(formname=="Dodawanie Administratora")
            {
                IDLabel.Hide();
                choice = 1;
            }
            if(formname=="Edycja danych Administratora")
            {
                id = id_n;
                choice = 2;
                UpdateData();
            }
            if(formname=="Wyświetlanie danych Administratora")
            {
                id = id_n;
                choice = 3;
                UpdateData();
                LoginBox.Enabled = false;
                PasswordBox.Enabled = false;
                TypeBox.Enabled = false;
                OKButton.Hide();
                ApplyButton.Hide();
                CancelButton.Text = "OK";
            }
        }

        private void UpdateData()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrator WHERE id_administrator='" + id + "';", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    login = rdr.GetString(1);
                    password = rdr.GetString(2);
                    type_name = rdr.GetString(3);
                    rdr.Close();
                    IDLabel.Text += "  " + id;
                    LoginBox.Text = login;
                    PasswordBox.Text = password;
                    TypeBox.Text = type_name;
                }
                else
                {
                    rdr.Close();
                    MessageBox.Show("Nie znaleziono Administratora", "Błąd");
                }
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

        private void AddAdmin()
        {
            login = LoginBox.Text;
            password = PasswordBox.Text;
            type_name = TypeBox.Text;
            if (login == "" || password==""||type_name=="") MessageBox.Show("Brak danych, uzupełnij wszystkie pola", "Błąd");
            else {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrator WHERE login='" + login + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read()) MessageBox.Show("Administrator o tym loginie już istnieje!", "Błąd");
                    else {
                        rdr.Close();
                        string insert_query = "INSERT INTO administrator (login,haslo,typ) VALUES ('" + login + "','" + password + "','" + type_name + "')";
                        MySqlCommand updateCmd = new MySqlCommand(insert_query, Form1.connection);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Dodano Administratora "+login, "Gratulacje");
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

        private void EditAdmin()
        {
            if (!b_pass && !b_login && !b_type) MessageBox.Show("Nic nie zostało zmienione", "Info");
            else {
                try
                {
                    //tutaj zapytanie edytujace dane
                    string edit_query = "UPDATE administrator SET ";
                    if (b_login)
                    {
                        edit_query += "login='" + LoginBox.Text + "' ";
                        if (b_pass || b_type) edit_query += ", ";
                        login = LoginBox.Text;
                        b_login = false;
                        edited = true;
                    }
                    if (b_pass)
                    {
                        edit_query += "haslo='" + PasswordBox.Text + "' ";
                        if (b_type) edit_query += ", ";
                        password = PasswordBox.Text;
                        b_pass = false;
                    }
                    if (b_type)
                    {
                        edit_query += "typ='" + TypeBox.Text + "' ";
                        type_name = TypeBox.Text;
                        b_type = false;
                    }
                    edit_query += "WHERE id_administrator='" + id + "';";
                    MySqlCommand updateCmd = new MySqlCommand(edit_query, Form1.connection);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Edytowano dane Administratora", "Gratulacje");
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

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            if (login == LoginBox.Text) b_login = false;
            else b_login = true;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (password == PasswordBox.Text) b_pass = false;
            else b_pass = true;
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_name == TypeBox.Text) b_type = false;
            else b_type = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(choice==1) AddAdmin();
            if (choice == 2) EditAdmin();
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if(choice==1) AddAdmin();
            if (choice == 2) EditAdmin();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
