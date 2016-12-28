using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql
{
    public partial class Panel : Form
    {
        public bool connected = true;
        public static EditUserForm euf1;
        public static AddUserForm auf1;
        public static EditBikeForm ebf1;
        Thread t1;
        public Panel()
        {
            InitializeComponent();
            //AddUserButton.Enabled = false;
            //DelUserButton.Enabled = false;
            //EditUserButton.Enabled = false;
            //EditBikeButton.Enabled = false;
            AddPlaceButton.Enabled = false;
            DelPlaceButton.Enabled = false;
            ShowABiPlaceButton.Enabled = false;
            //ExtraCostsPage.Hide();
            //ConnectionOKLabel.Hide();
            ConnectionBrakLabel.Hide();
            ShowAllUsers();
            ShowAllBikes();
            t1 = new Thread(ConnectCheck);
            t1.Start();
        }
        //sprawdzanie co 10s czy wciąż jest połączony do serwera
        private void ConnectCheck()
        {
            string temp;
            while (true)
            {
                temp = Form1.connection.State.ToString();
                if (temp != "Open")
                {
                    connected = false;
                    //if (MessageBox.Show("Czy chcesz wyłączyć Panel?", "Info", MessageBoxButtons.YesNo) == DialogResult.No)
                    //{
                    //    t1.Suspend();
                    //}
                    //else
                    //{
                    //    //t1.Suspend();
                    //    //Form.ActiveForm.Close();
                    //}

                }
                Thread.Sleep(10000);
            }
        }

        public void something()
        {
            if (!connected)
            {
                ConnectionOKLabel.Hide();
                ConnectionBrakLabel.Show();
            }
        }

        private string GenerateUserPassword()
        {
            string password="";
            //tutaj generowanie randomowego hasła
            return password;
        }

        //funkcja wypisuje wszystkich uzytkownikow do listbox'a
        private void ShowAllUsers()
        {
            try
            {
                UserListBox.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik ORDER BY login", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserListBox.Items.Add(rdr.GetString(1));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        //useless
        private void Panel_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Panel_load");
        }
        //funkcja wywoływana przy wciśnięciu zamknięcia okna potrzebna do zatrzymania wątku
        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Na pewno chcesz wyłączyć Panel?", "Info", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //t1.Suspend();
                t1.Abort();
            }
        }

        //button - dodawania użytkownika przez otwarcie odpowiedniej Form'y
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Panel.auf1 = new AddUserForm();
            Panel.auf1.ShowDialog();
            if (auf1.added) ShowAllUsers();
        }

        //button - usuwanie użytkownika
        private void DelUserButton_Click(object sender, EventArgs e)
        {
            string login = "";
            try
            {
                login = UserListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz uzytkownika", "Błąd");
            }
            if (login != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login='" + login + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        //tutaj usuwanie użytkownika
                        string delete_query = "DELETE FROM uzytkownik WHERE login='"+login+"';";
                        MySqlCommand updateCmd = new MySqlCommand(delete_query, Form1.connection);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Usunięto użytkownika "+login,"Gratulacje");
                        UpdateUserListBox(UserLoginBox.Text);
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika "+login, "Błąd");
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(),"ERROR");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"ERROR");
                }
            }

        }

        //button - pokazywanie danych użytkownika
        private void ShowUserButton_Click(object sender, EventArgs e)
        {
            
            string login = "";
            try {
                login = UserListBox.SelectedItem.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Wybierz uzytkownika", "Błąd");
            }
            if (login != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login='" + login + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        //wypisywanie danych użytkownika w messagebox
                        MessageBox.Show(@"ID: " + rdr.GetInt32(0).ToString() + "\n" +
                            "login: " + rdr.GetString(1) + "\n" +
                            "hasło: " + rdr.GetString(2) + "\n" +
                            "stan konta: " + rdr.GetFloat(3).ToString() + "\n" +
                            "status: " + rdr.GetString(4)+"\n"+
                            "imię: "+rdr.GetString(5)+"\n"+
                            "nazwisko: "+rdr.GetString(6)+"\n"+
                            "e-mail: "+rdr.GetString(7),"Info");
                    }

                    else MessageBox.Show("Nie znaleziono użytkownika "+login,"Błąd");
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(),"ERROR");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"ERROR");
                }
            }
        }

        //funkcja edycji użytkownika
        private void edit_user_data(MySqlDataReader rdr)
        {
            Panel.euf1 = new EditUserForm(rdr);
            Panel.euf1.ShowDialog();
            if (euf1.edited) ShowAllUsers();
        }

        //button - edytowanie użytkownika oraz pobranie jego danych z serwera
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            string login = "";
            try
            {
                login = UserListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz uzytkownika", "Błąd");
            }
            if (login != "")
            {
                try
                {
                    //znajdywanie uzytkownika w bazie danych
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login='" + login + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        edit_user_data(rdr);
                        rdr.Close();
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika "+login,"Błąd");
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(),"ERROR");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"ERROR");
                }
            }
        }

        //funkcja uaktualnia listę użytkowników
        private void UpdateUserListBox(string UserName)
        {
            if (UserName == "") ShowAllUsers();
            else
            {
                try
                {
                    UserListBox.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login LIKE '%" + UserName + "%' ORDER BY login", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        UserListBox.Items.Add(rdr.GetString(1));
                    }
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        //textchanged - podczas wpisywania nazwy użytkownika wywołuje funkcje
        private void UserLoginBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUserListBox(UserLoginBox.Text);
        }

        //nie używane
        private void UserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //funkcja wypisuje wszystkie rowery do listbox'a
        private void ShowAllBikes()
        {
            try
            {
                BikeListBox.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery ORDER BY numer", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    BikeListBox.Items.Add(rdr.GetInt32(3));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        //button - dodawania roweru
        private void AddBikeButton_Click(object sender, EventArgs e)
        {
            int number=0;
            if (BikeNrTextBox.Text == "")
            {
                MessageBox.Show("Dodanie roweru wymaga podanie jego numeru!", "Błąd");
            }
            else
            {
                try
                {
                    number = Int32.Parse(BikeNrTextBox.Text);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE numer='" + BikeNrTextBox.Text + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read()) MessageBox.Show("Rower o tym numerze już istnieje!", "Błąd");
                    else
                    {
                        //tutaj zapytanie dodajace uzytkownika

                        rdr.Close();
                        string insert_query = "INSERT INTO rowery (numer,wypozyczony) VALUES ('" + number + "', '0')";
                        MySqlCommand updateCmd = new MySqlCommand(insert_query, Form1.connection);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Dodano rower o numerze: " + number, "Gratulacje");
                        UpdateBikeListBox(BikeNrTextBox.Text);
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

        //funkcja uaktualnia listę rowerów przyjmując numer roweru
        private void UpdateBikeListBox(string BikeNumber)
        {
            if (BikeNumber == "") ShowAllBikes();
            else
            {
                try
                {
                    BikeListBox.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE numer LIKE '%" + BikeNumber + "%' ORDER BY numer", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        BikeListBox.Items.Add(rdr.GetInt32(3));
                    }
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        //textchanged - podczas wpisywania numeru roweru uaktualniana jest lista rowerów
        private void BikeNrTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateBikeListBox(BikeNrTextBox.Text);
        }

        //button - usuwanie roweru
        private void DelBikeButton_Click(object sender, EventArgs e)
        {
            string numer = "";
            try
            {
                numer = BikeListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz rower", "Błąd");
            }
            if (numer != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE numer='" + numer + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        //tutaj usuwanie roweru
                        string delete_query = "DELETE FROM rowery WHERE numer='" + numer + "';";
                        MySqlCommand updateCmd = new MySqlCommand(delete_query, Form1.connection);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Usunięto rower o numerze: " + numer, "Gratulacje");
                        ShowAllBikes();
                    }
                    else MessageBox.Show("Nie znaleziono roweru o numerze: " + numer, "Błąd");
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

        private void ShowBikeButton_Click(object sender, EventArgs e)
        {
            string numer = "",answer="", message="";
            try
            {
                numer = BikeListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz rower", "Błąd");
            }
            if (numer != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE numer='" + numer + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (rdr.GetInt16(4).ToString() == "1") answer = "Tak";
                        else answer = "Nie";
                        message += @"ID: " + rdr.GetInt32(0).ToString() + "\n"+
                            "numer roweru: " + rdr.GetInt32(3).ToString() + "\n" +
                            "wypozyczony: " + answer;
                        try {
                            if (rdr.GetInt32(1).ToString() != null)
                                message += "\nID-użytkownika: " + rdr.GetInt32(1).ToString();
                        }
                        catch (Exception) { }
                        try
                        {
                            if (rdr.GetInt32(2).ToString() != null)
                                message += "\nID-miejsca: " + rdr.GetInt32(2).ToString();
                        }
                        catch (Exception) { }
                        //wypisywanie danych użytkownika w messagebox
                       
                        
                            MessageBox.Show(message/*"ID: " + rdr.GetInt32(0).ToString() + "\n" +
                            "ID-użytkownika: " + rdr.GetInt32(1).ToString() + "\n" +
                            "ID-miejsca: " + rdr.GetInt32(2).ToString() + "\n" +
                            "numer roweru: " + rdr.GetInt32(3).ToString() + "\n" +
                            "wypozyczony: " +  answer*/, "Info");
                    }

                    else MessageBox.Show("Nie znaleziono użytkownika " + UserLoginBox.Text, "Błąd");
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

        //useless
        private void Panel_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("Panel_shown");
        }

        private void EditBikeButton_Click(object sender, EventArgs e)
        {
            string number = "";
            try
            {
                number = BikeListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz rower", "Błąd");
            }
            if (number != "")
            {
                try
                {
                    //znajdywanie uzytkownika w bazie danych
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE numer='" + number + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Panel.ebf1 = new EditBikeForm(rdr);
                        Panel.ebf1.ShowDialog();
                        if (ebf1.edited) ShowAllBikes();
                        rdr.Close();
                    }
                    else MessageBox.Show("Nie znaleziono roweru o numerze: " + number, "Błąd");
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
    }
}

       

