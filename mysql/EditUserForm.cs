using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql
{
    public partial class EditUserForm : Form
    {
        public bool edited=false;
        private string login="";
        private string password="";
        private float financial=0;
        private string status="";
        private string name = "";
        private string surname = "";
        private string email = "";
        //private MySqlDataReader dane;
        public EditUserForm(MySqlDataReader rdr)
        {
            InitializeComponent();
            //EditUserDataButton.Enabled = false;
            //EdUserLoginTBox.Enabled = false;
            //EdUserPassTBox.Enabled = false;
            //EdUserFinancialTBox.Enabled = false;
            //EdUserStatusCBox.Enabled = false;
            //EdUserMailTBox.Enabled = false;
            //EdUserNameTBox.Enabled = false;
            //EdUserSurnameTBox.Enabled = false;
            ImportData(rdr);
            rdr.Close();
            EdUserLoginTBox.Text = login;
            EdUserPassTBox.Text = password;
            EdUserFinancialTBox.Text = financial.ToString();
            EdUserStatusCBox.Text = status;
            EdUserNameTBox.Text = name;
            EdUserSurnameTBox.Text = surname;
            EdUserMailTBox.Text = email;
            //EdUserStatusTBox1.Text = status;
        }

        private void ImportData(MySqlDataReader rdr)
        {
            //dane = rdr;
            login = rdr.GetString(1);
            password = rdr.GetString(2);
            financial = rdr.GetFloat(3);
            status = rdr.GetString(4);
            name = rdr.GetString(5);
            surname = rdr.GetString(6);
            email = rdr.GetString(7);
        }

        private bool b_status = false, b_fin = false, b_pass = false, b_login = false, b_name=false, b_surname=false, b_email=false;

        private void EditUser()
        {
            if (!b_status && !b_fin && !b_pass && !b_login && !b_email && !b_name && !b_surname) MessageBox.Show("Nic nie zostało zmienione", "Info");
            else {
                try
                {
                    //tutaj zapytanie edytujace dane
                    string edit_query = "UPDATE uzytkownik SET ";
                    if (b_login)
                    {
                        edit_query += "login='" + EdUserLoginTBox.Text + "' ";
                        if (b_pass || b_fin || b_status || b_name || b_surname || b_email) edit_query += ", ";
                        b_login = false;
                        edited = true;
                    }
                    if (b_pass)
                    {
                        edit_query += "haslo='" + EdUserPassTBox.Text + "' ";
                        if (b_fin || b_status || b_name || b_surname || b_email) edit_query += ", ";
                        password = EdUserPassTBox.Text;
                        b_pass = false;
                    }
                    if (b_fin)
                    {
                        edit_query += "stan_konta='" + EdUserFinancialTBox.Text + "' ";
                        if (b_status || b_name || b_surname || b_email) edit_query += ", ";
                        financial = float.Parse(EdUserFinancialTBox.Text);
                        b_fin = false;
                    }
                    if (b_status)
                    {
                        edit_query += "stat='" + EdUserStatusCBox.Text + "' ";
                        if (b_name || b_surname || b_email) edit_query += ", ";
                        status = EdUserStatusCBox.Text;
                        b_status = false;
                    }
                    if (b_name)
                    {
                        edit_query += "imie='" + EdUserNameTBox.Text + "' ";
                        if (b_surname || b_email) edit_query += ", ";
                        name = EdUserNameTBox.Text;
                        b_name = false;
                    }
                    if (b_surname)
                    {
                        edit_query += "nazwisko='" + EdUserSurnameTBox.Text + "' ";
                        if (b_email) edit_query += ", ";
                        surname = EdUserSurnameTBox.Text;
                        b_surname = false;
                    }
                    if (b_email)
                    {
                        edit_query += "email='" + EdUserMailTBox.Text + "' ";
                        email = EdUserMailTBox.Text;
                        b_email = false;
                    }
                    edit_query += "WHERE login='" + login + "';";
                    MySqlCommand updateCmd = new MySqlCommand(edit_query, Form1.connection);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Edytowano dane użytkownika", "Gratulacje");
                    login = EdUserLoginTBox.Text;
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

        private void EditUserDataButton_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void EdUserStatusCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status == EdUserStatusCBox.Text) b_status = false;
            else b_status = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            EditUser();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EdUserLoginTBox_TextChanged(object sender, EventArgs e)
        {
            if (login == EdUserLoginTBox.Text) b_login = false;
            else b_login = true;
        }

        private void EdUserPassTBox_TextChanged(object sender, EventArgs e)
        {
            if (password == EdUserPassTBox.Text) b_pass = false;
            else b_pass = true;
        }

        private void EdUserFinancialTBox_TextChanged(object sender, EventArgs e)
        {
            if (financial == float.Parse(EdUserFinancialTBox.Text)) b_fin = false;
            else b_fin = true;
        }

        private void EdUserSurnameTBox_TextChanged(object sender, EventArgs e)
        {
            if (surname == EdUserSurnameTBox.Text) b_surname = false;
            else b_surname = true;
        }

        private void EdUserMailTBox_TextChanged(object sender, EventArgs e)
        {
            if (email == EdUserMailTBox.Text) b_email = false;
            else b_email = true;
        }

        private void EdUserNameTBox_TextChanged(object sender, EventArgs e)
        {
            if (name == EdUserNameTBox.Text) b_name = false;
            else b_name = true;
        }
    }
}
