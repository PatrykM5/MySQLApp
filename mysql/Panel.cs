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
        public static EditPlaceForm epf1;
        public static AddECostForm aecf1;
        public static AddAdminForm aaf1;
        public static AddPaymentForm apf1;
        public static PaymentForm pf1;
        //public static EditPaymentForm epf1;
        private string type_name = "";
        //Thread t1;
        public Panel(string type)
        {
            InitializeComponent();
            type_name = type;
            //AddUserButton.Enabled = false;
            //DelUserButton.Enabled = false;
            //EditUserButton.Enabled = false;
            //EditBikeButton.Enabled = false;
            //AddPlaceButton.Enabled = false;
            //DelPlaceButton.Enabled = false;
            ShowABiPlaceButton.Hide();
            DelExtraCostButton.Hide();
            //ExtraCostsPage.Hide();
            //ConnectionOKLabel.Hide();
            ConnectionBrakLabel.Hide();
            DelPaymentButton.Hide();
            EditPaymentButton.Hide();
            FindButton.Hide();
            FindLabel.Hide();
            FindBox.Hide();
            ShowAllUsers(12);
            ShowAllBikes();
            ShowAllPlaces();
            ShowAllAdmins();
            backgroundW.DoWork += backgroundW_DoWork;
            backgroundW.ProgressChanged += backgroundW_ProgressChanged;
            backgroundW.RunWorkerAsync();
            if (type == "zwykły")
            {
                //tutaj mogą być jakieś ograniczenia
                DelUserButton.Enabled = false;
                DelPlaceButton.Enabled = false;
                DelBikeButton.Enabled = false;
                AddAdminButton.Enabled = false;
                DelAdminButton.Enabled = false;
                ShowAdminButton.Enabled = false;
                EditAdminButton.Enabled = false;
            }
            //t1 = new Thread(ConnectCheck);
            //t1.Start();
        }
        //sprawdzanie co 10s czy wciąż jest połączony do serwera, nieużywane
        private void ConnectCheck()
        {
            string temp;
            while (true)
            {
                temp = Form1.connection.State.ToString();
                if (temp != "Open")
                {
                    connected = false;
                    backgroundW.RunWorkerAsync();
                   

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
            string password = "";
            //tutaj generowanie randomowego hasła
            return password;
        }

        //funkcja wypisuje wszystkich uzytkownikow do listbox'a
        private void ShowAllUsers(int listbox)
        {
            try
            {
                if (listbox == 1) UserListBox.Items.Clear();
                if (listbox == 2) UserListBox2.Items.Clear();
                if (listbox == 3) UserListBox3.Items.Clear();
                if (listbox == 12)
                {
                    UserListBox.Items.Clear();
                    UserListBox2.Items.Clear();
                    UserListBox3.Items.Clear();
                }
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik ORDER BY login", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (listbox == 1) UserListBox.Items.Add(rdr.GetString(1));
                    if (listbox == 2) UserListBox2.Items.Add(rdr.GetString(1));
                    if (listbox == 3) UserListBox3.Items.Add(rdr.GetString(1));
                    if (listbox == 12)
                    {
                        UserListBox.Items.Add(rdr.GetString(1));
                        UserListBox2.Items.Add(rdr.GetString(1));
                        UserListBox3.Items.Add(rdr.GetString(1));
                    }
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
        //funkcja wywoływana przy wciśnięciu zamknięcia okna
        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Na pewno chcesz wyłączyć Panel?", "Info", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        //button - dodawania użytkownika przez otwarcie odpowiedniej Form'y
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Panel.auf1 = new AddUserForm();
            Panel.auf1.ShowDialog();
            if (auf1.added) ShowAllUsers(12);
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
                        string delete_query = "DELETE FROM uzytkownik WHERE login='" + login + "';";
                        MySqlCommand updateCmd = new MySqlCommand(delete_query, Form1.connection);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Usunięto użytkownika " + login, "Gratulacje");
                        UpdateUserListBox(UserLoginBox.Text, 1);
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        //button - pokazywanie danych użytkownika
        private void ShowUserButton_Click(object sender, EventArgs e)
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
                        edit_user_data(rdr, "Wyświetl dane użytkownika");
                        rdr.Close();
                        /*
                        //wypisywanie danych użytkownika w messagebox
                        MessageBox.Show(@"ID: " + rdr.GetInt32(0).ToString() + "\n" +
                            "login: " + rdr.GetString(1) + "\n" +
                            "hasło: " + rdr.GetString(2) + "\n" +
                            "stan konta: " + rdr.GetFloat(3).ToString() + "\n" +
                            "status: " + rdr.GetString(4)+"\n"+
                            "imię: "+rdr.GetString(5)+"\n"+
                            "nazwisko: "+rdr.GetString(6)+"\n"+
                            "e-mail: "+rdr.GetString(7),"Info");
                            */
                    }

                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        //funkcja edycji użytkownika
        private void edit_user_data(MySqlDataReader rdr, string s)
        {
            Panel.euf1 = new EditUserForm(rdr, s);
            Panel.euf1.ShowDialog();
            if (euf1.edited) ShowAllUsers(12);
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
                        edit_user_data(rdr, "Edytuj dane użytkownika");
                        rdr.Close();
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        //funkcja uaktualnia listę użytkowników
        private void UpdateUserListBox(string UserName, int listbox)
        {
            if (UserName == "") ShowAllUsers(listbox);
            else
            {
                try
                {
                    if (listbox == 1) UserListBox.Items.Clear();
                    if (listbox == 2) UserListBox2.Items.Clear();
                    if(listbox==3) UserListBox3.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login LIKE '%" + UserName + "%' ORDER BY login", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (listbox == 1) UserListBox.Items.Add(rdr.GetString(1));
                        if (listbox == 2) UserListBox2.Items.Add(rdr.GetString(1));
                        if (listbox == 3) UserListBox3.Items.Add(rdr.GetString(1));
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
            UpdateUserListBox(UserLoginBox.Text, 1);
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery ORDER BY id_rower", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    BikeListBox.Items.Add(rdr.GetInt32(0));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        //button - dodawania roweru do poprawy
        private void AddBikeButton_Click(object sender, EventArgs e)
        {
            //int number = 0;
            //if (BikeNrTextBox.Text == "")
            //{
            //    MessageBox.Show("Dodanie roweru wymaga podania jego numeru!", "Błąd");
            //}
            //else
            //{
            MySqlDataReader rdr = null;
            Panel.ebf1 = new EditBikeForm(rdr, "Dodaj rower");
            Panel.ebf1.ShowDialog();
            if (ebf1.edited) ShowAllBikes();
            /*try
                {
                    //number = Int32.Parse(BikeNrTextBox.Text);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE id_rower='" + BikeNrTextBox.Text + "';", Form1.connection);
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
            //}
            */
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
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE id_rower LIKE '%" + BikeNumber + "%' ORDER BY id_rower", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        BikeListBox.Items.Add(rdr.GetInt32(0));
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
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE id_rower='" + numer + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        //tutaj usuwanie roweru
                        string delete_query = "DELETE FROM rowery WHERE id_rower='" + numer + "';";
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
            string numer = "", answer = "", message = "";
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
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE id_rower='" + numer + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Panel.ebf1 = new EditBikeForm(rdr, "Wyświetl dane roweru");
                        Panel.ebf1.ShowDialog();
                        /*
                        if (rdr.GetInt16(4).ToString() == "1") answer = "Tak";
                        else answer = "Nie";
                        message += @"ID: " + rdr.GetInt32(0).ToString() + "\n"+
                            "numer roweru: " + rdr.GetInt32(3).ToString() + "\n" +
                            "wypozyczony: " + answer;
                        if (answer == "Tak")
                        {
                            try
                            {
                                if (rdr.GetInt32(1).ToString() != null)
                                    message += "\nID-użytkownika: " + rdr.GetInt32(1).ToString();
                            }
                            catch (Exception) { }
                        }
                        try
                        {
                            if (rdr.GetInt32(2).ToString() != null)
                                message += "\nID-miejsca: " + rdr.GetInt32(2).ToString();
                        }
                        catch (Exception) { }
                        //wypisywanie danych użytkownika w messagebox
                       
                        
                            MessageBox.Show(message, "Info");
                            */
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
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery WHERE id_rower='" + number + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Panel.ebf1 = new EditBikeForm(rdr, "Edytuj dane roweru");
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

        private void ShowAllPlaces()
        {
            try
            {
                PlaceListBox.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca ORDER BY nazwa", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    PlaceListBox.Items.Add(rdr.GetString(1));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void UpdatePlaceListBox(string PlaceName)
        {
            if (PlaceName == "") ShowAllPlaces();
            else
            {
                try
                {
                    PlaceListBox.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE nazwa LIKE '%" + PlaceName + "%' ORDER BY nazwa", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        PlaceListBox.Items.Add(rdr.GetString(1));
                    }
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        private void PlaceNameBox_TextChanged(object sender, EventArgs e)
        {
            string name = "";
            name = PlaceNameBox.Text;
            UpdatePlaceListBox(name);
        }

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            string name = "";
            name = PlaceNameBox.Text;
            if (name != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE nazwa='" + name + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read()) MessageBox.Show("Miejsce o podanej nazwie już istnieje!", "Błąd");
                    else
                    {
                        //tutaj zapytanie dodajace uzytkownika

                        rdr.Close();
                        string insert_query = "INSERT INTO miejsca (nazwa) VALUES ('" + name + "')";
                        MySqlCommand updateCmd = new MySqlCommand(insert_query, Form1.connection);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Dodano miejsce o nazwie: " + name, "Gratulacje");
                        UpdatePlaceListBox(PlaceNameBox.Text);
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
            else
            {
                MessageBox.Show("Należy podać nazwę miejsca", "Błąd");
            }
        }

        private void DelPlaceButton_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                name = PlaceListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz miejsce", "Błąd");
            }
            if (name != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE nazwa='" + name + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        //tutaj usuwanie użytkownika
                        string delete_query = "DELETE FROM miejsca WHERE nazwa='" + name + "';";
                        MySqlCommand updateCmd = new MySqlCommand(delete_query, Form1.connection);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Usunięto miejsce " + name, "Gratulacje");
                        UpdatePlaceListBox(PlaceNameBox.Text);
                    }
                    else MessageBox.Show("Nie znaleziono miejsca " + name, "Błąd");
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

        private void EditPlaceButton_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                name = PlaceListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz miejsce", "Błąd");
            }
            if (name != "")
            {
                try
                {
                    //znajdywanie uzytkownika w bazie danych
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE nazwa='" + name + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Panel.epf1 = new EditPlaceForm(rdr, "Edytuj dane miejsca");
                        Panel.epf1.ShowDialog();
                        if (epf1.edited) ShowAllPlaces();
                        rdr.Close();
                    }
                    else MessageBox.Show("Nie znaleziono miejsca o nazwie: " + name, "Błąd");
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

        private void ShowPlaceButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string message = "";
            try
            {
                name = PlaceListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz miejsce", "Błąd");
            }
            if (name != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE nazwa='" + name + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        /*
                        //wypisanie danych miejsca w messagebox'ie
                        message += "ID: " + rdr.GetInt32(0).ToString() + "\nNazwa: "+rdr.GetString(1);
                        MessageBox.Show(message, "Info");
                        */
                        Panel.epf1 = new EditPlaceForm(rdr, "Wyświetl dane miejsca");
                        Panel.epf1.ShowDialog();
                    }
                    else MessageBox.Show("Nie znaleziono miejsca " + name, "Błąd");
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

        private void backgroundW_DoWork(object sender, DoWorkEventArgs e)
        {
            Action updateAction1 = new Action(ConnectionBrakLabel.Show);
            Action updateAction2 = new Action(ConnectionBrakLabel.Hide);
            string temp;
            bool changed = false;
            bool temp_b = false;
            while (true)
            {
                try {
                    //Form1.connection.Ping();
                    temp = Form1.connection.State.ToString();
                    if (temp != "Open")
                    {
                        temp_b = connected;
                        connected = false;
                        if (connected == temp_b) changed = false;
                        else changed = true;
                        //backgroundW.RunWorkerAsync();
                        if (changed) ConnectionBrakLabel.Invoke(updateAction1);
                        if (MessageBox.Show("Utracono połączenie, odnowić?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                Form1.connection.Open();
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.ToString(), "ERROR!");
                            }
                        }
                        else
                        {
                            //t1.Suspend();
                            //this.Close();
                            Thread.Sleep(10000);
                        }
                        temp = Form1.connection.State.ToString();
                    }
                    else if (temp == "Open")
                    {
                        temp_b = connected;
                        connected = true;
                        if (connected == temp_b) changed = false;
                        else changed = true;
                        if (changed) ConnectionBrakLabel.Invoke(updateAction2);
                    }
                    Thread.Sleep(1000);
                }
                catch (Exception)
                {
                    //tutaj może obsługa wyjątku
                }
            }
        }

        private void backgroundW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void UserLoginBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateUserListBox(UserLoginBox2.Text, 2);
        }

        private void AddExtraCostButton_Click(object sender, EventArgs e)
        {
            string login = "";
            int id = 0;
            try
            {
                login = UserListBox2.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz użytkownika", "Błąd");
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
                        id = rdr.GetInt16(0);
                        rdr.Close();
                        aecf1 = new AddECostForm(id, login, "Dodawanie kosztu dodatkowego");
                        aecf1.ShowDialog();

                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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
        //nie używany, schowany button
        private void DelExtraCostButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowExtraCostButton_Click(object sender, EventArgs e)
        {
            string login = "";
            int id = 0;
            try
            {
                login = UserListBox2.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz użytkownika", "Błąd");
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
                        id = rdr.GetInt16(0);
                        rdr.Close();
                        MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM koszty_dodatkowe WHERE id_uzytkownik='" + id + "';", Form1.connection);
                        MySqlDataReader rdr1 = null;
                        rdr1 = cmd1.ExecuteReader();
                        if (rdr1.Read())
                        {
                            rdr1.Close();
                            aecf1 = new AddECostForm(id, login, "Wyświetlanie kosztów dodatkowych");
                            aecf1.ShowDialog();
                        }
                        else
                        {
                            rdr1.Close();
                            MessageBox.Show("Brak kosztów dodatkowych użytkownika", "Informacja");
                        }
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        private void EditExtraCostButton_Click(object sender, EventArgs e)
        {
            string login = "";
            int id = 0;
            try
            {
                login = UserListBox2.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz użytkownika", "Błąd");
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
                        id = rdr.GetInt16(0);
                        rdr.Close();

                        MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM koszty_dodatkowe WHERE id_uzytkownik='" + id + "';", Form1.connection);
                        MySqlDataReader rdr1 = null;
                        rdr1 = cmd1.ExecuteReader();
                        if (rdr1.Read())
                        {
                            rdr1.Close();
                            aecf1 = new AddECostForm(id, login, "Edycja kosztów dodatkowych");
                            aecf1.ShowDialog();
                            
                        }
                        else
                        {
                            rdr1.Close();
                            MessageBox.Show("Brak kosztów dodatkowych użytkownika", "Informacja");
                        }
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        private void PanelControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (type_name == "zwykły")
            {
                if (e.TabPage == AdminsPage) { e.Cancel = true; MessageBox.Show("Brak uprawnień dostępu!", "Info"); }
            }
        }

        private void ShowAllAdmins()
        {
            try
            {
                AdminListBox.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrator ORDER BY login", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    AdminListBox.Items.Add(rdr.GetString(1));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            //tutaj dodawanie administratora
            Panel.aaf1 = new AddAdminForm("Dodawanie Administratora",0);
            Panel.aaf1.ShowDialog();
            if (aaf1.added) ShowAllAdmins();
        }

        private void DelAdminButton_Click(object sender, EventArgs e)
        {
            //tutaj usuwanie administratora
        }

        private void ShowAdminButton_Click(object sender, EventArgs e)
        {
            //tutaj pokazywanie danych administratora
            string login = "";
            int id = 0;
            try
            {
                login = AdminListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz Administratora", "Błąd");
            }
            if (login != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrator WHERE login='" + login + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        id = rdr.GetInt32(0);
                        rdr.Close();
                        Panel.aaf1 = new AddAdminForm("Wyświetlanie danych Administratora", id);
                        Panel.aaf1.ShowDialog();
                        
                    }
                    else MessageBox.Show("Nie znaleziono Administratora " + login, "Błąd");
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

        private void EditAdminButton_Click(object sender, EventArgs e)
        {
            //tutaj edytowanie danych administratora
            string login = "";
            int id = 0;
            try
            {
                login = AdminListBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wybierz Administratora", "Błąd");
            }
            if (login != "")
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrator WHERE login='" + login + "';", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        id = rdr.GetInt32(0);
                        rdr.Close();
                        Panel.aaf1 = new AddAdminForm("Edycja danych Administratora", id);
                        Panel.aaf1.ShowDialog();
                        if (aaf1.edited) ShowAllAdmins();
                    }
                    else MessageBox.Show("Nie znaleziono Administratora " + login, "Błąd");
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

        private void UpdateAdminListBox(string AdminName)
        {
            if (AdminName == "") ShowAllAdmins();
            else
            {
                try
                {
                    AdminListBox.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM administrator WHERE login LIKE '%" + AdminName + "%' ORDER BY login", Form1.connection);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        AdminListBox.Items.Add(rdr.GetString(1));
                    }
                    rdr.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        private void AdminLoginBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAdminListBox(AdminLoginBox.Text);
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            int id=0;
            string login = "";
            decimal money = 0;
            string status = "";
            try
            {
                login = UserListBox3.SelectedItem.ToString();
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
                        id=rdr.GetInt32(0);
                        money = rdr.GetDecimal(3);
                        status = rdr.GetString(4);
                        rdr.Close();
                        if (status == "Aktywny")
                        {
                            Panel.apf1 = new AddPaymentForm(id, login, money);
                            Panel.apf1.ShowDialog();
                        }
                        else MessageBox.Show("Użytkownik nie jest Aktywny, nie można dodać wpłaty.", "Info");
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        private void DelPaymentButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            string login = "";
            try
            {
                login = UserListBox3.SelectedItem.ToString();
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
                        id = rdr.GetInt32(0);
                        rdr.Close();
                        //od tego miejsca pozmieniać
                        //Panel.apf1 = new AddPaymentForm(id, login);
                        //Panel.apf1.ShowDialog();
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        private void ShowPaymentButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            string login = "";
            try
            {
                login = UserListBox3.SelectedItem.ToString();
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
                        id = rdr.GetInt32(0);
                        rdr.Close();
                        //MessageBox.Show("ID:" + id.ToString());
                        //od tego miejsca pozmieniać
                        Panel.pf1 = new PaymentForm(id, login,"Wyświetlanie płatności");
                        Panel.pf1.ShowDialog();
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        private void EditPaymentButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            string login = "";
            try
            {
                login = UserListBox3.SelectedItem.ToString();
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
                        id = rdr.GetInt32(0);
                        rdr.Close();
                        //od tego miejsca pozmieniać
                        //Panel.apf1 = new AddPaymentForm(id, login);
                        //Panel.apf1.ShowDialog();
                    }
                    else MessageBox.Show("Nie znaleziono użytkownika " + login, "Błąd");
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

        private void UserLoginBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateUserListBox(UserLoginBox3.Text, 3);
        }

        private void FindLogin()
        {
            try
            {
                FindBox.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik ORDER BY login", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    FindBox.Items.Add(rdr.GetString(1));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void FindBike()
        {
            try
            {
                FindBox.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rowery ORDER BY id_rower", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    FindBox.Items.Add(rdr.GetInt32(0));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void FindPlace()
        {
            try
            {
                FindBox.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca ORDER BY nazwa", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    FindBox.Items.Add(rdr.GetString(1));
                }
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void ChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loginie,nr rower,miejscu
            if (ChoiceBox.Text == "loginie")
            {
                FindLabel.Text = "Podaj login:";
                FindLogin();
                FindBox.Text = "";
            }
            else if (ChoiceBox.Text == "nr roweru")
            {
                FindLabel.Text = "Podaj numer:";
                FindBike();
                FindBox.Text = "";
            }
            else if (ChoiceBox.Text == "miejscu")
            {
                FindLabel.Text = "Podaj miejsce:";
                FindPlace();
                FindBox.Text = "";
            }
            FindLabel.Show();
            FindBox.Show();
        }

        private void FoundLogin(string login)
        {
            int id_user = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login='" + login + "'", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    id_user = rdr.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Brak użytkonika", "Info");
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
            //MessageBox.Show("Uzupełnianie danych");
            try
            {
                //SELECT SupplierID, CompanyName,
                //(SELECT MIN(UnitPrice) FROM Products WHERE SupplierID = z.SupplierID) AS Cena
                //FROM Suppliers z;
                MySqlCommand cmd = new MySqlCommand(@"SELECT id_wypozyczenia, id_rower,
                (SELECT login FROM uzytkownik u WHERE u.id_uzytkownik=w.id_uzytkownik), data_wypozyczenia, data_zwrotu,
                (SELECT nazwa FROM miejsca m1 WHERE m1.id_miejsca=w.id_miejsca_wypozyczenia),
                (SELECT nazwa FROM miejsca m2 WHERE m2.id_miejsca=w.id_miejsca_oddania), koszt
                FROM wypozyczenia w WHERE id_uzytkownik='" + id_user.ToString()+ "' AND (NOT id_miejsca_oddania='NULL');", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                //tutaj uzupełnianie tabelki, nie wchodzi do pętli
                while (rdr.Read())
                {
                    //MessageBox.Show("hello");
                    FindTabel.ColumnCount = 8;
                    FindTabel.ColumnHeadersVisible = true;

                    // Set the column header style.
                    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                    columnHeaderStyle.BackColor = Color.Beige;
                    columnHeaderStyle.Font = new Font("Verdana", 7, FontStyle.Regular);
                    FindTabel.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                    // Set the column header names.
                    FindTabel.Columns[0].Name = "ID";
                    FindTabel.Columns[1].Name = "Rower";
                    FindTabel.Columns[2].Name = "Użytkownik";
                    FindTabel.Columns[3].Name = "Wypożyczono";
                    FindTabel.Columns[4].Name = "Oddano";
                    FindTabel.Columns[5].Name = "Z";
                    FindTabel.Columns[6].Name = "Do";
                    FindTabel.Columns[7].Name = "Koszt";
                    //FindTabel.Columns[8].Name = "Czas [h]";

                    //utworzenie wpisu w wiersz i umieszczenie w tabeli
                    string[] row_d = new string[] { rdr.GetInt32(0).ToString(), rdr.GetInt32(1).ToString(), rdr.GetString(2), rdr.GetDateTime(3).ToString("dd.MM.yyyy"),
                    rdr.GetDateTime(4).ToString("dd.MM.yyyy"), rdr.GetString(5), rdr.GetString(6), rdr.GetDecimal(7).ToString()};
                    //MessageBox.Show(row_d.ToString());
                    FindTabel.Rows.Add(row_d);

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

        private void FoundBike(string number)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(@"SELECT id_wypozyczenia, id_rower,
                (SELECT login FROM uzytkownik u WHERE u.id_uzytkownik=w.id_uzytkownik), data_wypozyczenia, data_zwrotu,
                (SELECT nazwa FROM miejsca m1 WHERE m1.id_miejsca=w.id_miejsca_wypozyczenia),
                (SELECT nazwa FROM miejsca m2 WHERE m2.id_miejsca=w.id_miejsca_oddania), koszt, czas
                FROM wypozyczenia w WHERE id_rower='" + number.ToString() + "' AND (NOT id_miejsca_oddania='NULL');", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                //tutaj uzupełnianie tabelki, nie wchodzi do pętli
                while (rdr.Read())
                {
                    //MessageBox.Show("hello");
                    FindTabel.ColumnCount = 8;
                    FindTabel.ColumnHeadersVisible = true;

                    // Set the column header style.
                    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                    columnHeaderStyle.BackColor = Color.Beige;
                    columnHeaderStyle.Font = new Font("Verdana", 7, FontStyle.Regular);
                    FindTabel.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                    // Set the column header names.
                    FindTabel.Columns[0].Name = "ID";
                    FindTabel.Columns[1].Name = "Rower";
                    FindTabel.Columns[2].Name = "Użytkownik";
                    FindTabel.Columns[3].Name = "Wypożyczono";
                    FindTabel.Columns[4].Name = "Oddano";
                    FindTabel.Columns[5].Name = "Z";
                    FindTabel.Columns[6].Name = "Do";
                    FindTabel.Columns[7].Name = "Koszt";
                    //FindTabel.Columns[8].Name = "Czas [h]";

                    //utworzenie wpisu w wiersz i umieszczenie w tabeli
                    string[] row_d = new string[] { rdr.GetInt32(0).ToString(), rdr.GetInt32(1).ToString(), rdr.GetString(2), rdr.GetDateTime(3).ToString("dd.MM.yyyy"),
                    rdr.GetDateTime(4).ToString("dd.MM.yyyy"), rdr.GetString(5), rdr.GetString(6), rdr.GetDecimal(7).ToString()};
                    //MessageBox.Show(row_d.ToString());
                    FindTabel.Rows.Add(row_d);

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

        private void FoundPlace(string name)
        {
            int id_place = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE nazwa='" + name + "'", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    id_place = rdr.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Brak miejsca", "Info");
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
            //MessageBox.Show("Uzupełnianie danych");
            try
            {
                //SELECT SupplierID, CompanyName,
                //(SELECT MIN(UnitPrice) FROM Products WHERE SupplierID = z.SupplierID) AS Cena
                //FROM Suppliers z;
                MySqlCommand cmd = new MySqlCommand(@"SELECT id_wypozyczenia, id_rower,
                (SELECT login FROM uzytkownik u WHERE u.id_uzytkownik=w.id_uzytkownik), data_wypozyczenia, data_zwrotu,
                (SELECT nazwa FROM miejsca m1 WHERE m1.id_miejsca=w.id_miejsca_wypozyczenia),
                (SELECT nazwa FROM miejsca m2 WHERE m2.id_miejsca=w.id_miejsca_oddania), koszt, czas
                FROM wypozyczenia w WHERE (id_miejsca_wypozyczenia='" + id_place.ToString() + "' OR id_miejsca_oddania='"+ id_place.ToString()+ "') AND (NOT id_miejsca_oddania='NULL');", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                //tutaj uzupełnianie tabelki, nie wchodzi do pętli
                while (rdr.Read())
                {
                    //MessageBox.Show("hello");
                    FindTabel.ColumnCount = 8;
                    FindTabel.ColumnHeadersVisible = true;

                    // Set the column header style.
                    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                    columnHeaderStyle.BackColor = Color.Beige;
                    columnHeaderStyle.Font = new Font("Verdana", 7, FontStyle.Regular);
                    FindTabel.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                    // Set the column header names.
                    FindTabel.Columns[0].Name = "ID";
                    FindTabel.Columns[1].Name = "Rower";
                    FindTabel.Columns[2].Name = "Użytkownik";
                    FindTabel.Columns[3].Name = "Wypożyczono";
                    FindTabel.Columns[4].Name = "Oddano";
                    FindTabel.Columns[5].Name = "Z";
                    FindTabel.Columns[6].Name = "Do";
                    FindTabel.Columns[7].Name = "Koszt";
                    //FindTabel.Columns[8].Name = "Czas [h]";

                    //utworzenie wpisu w wiersz i umieszczenie w tabeli
                    string[] row_d = new string[] { rdr.GetInt32(0).ToString(), rdr.GetInt32(1).ToString(), rdr.GetString(2), rdr.GetDateTime(3).ToString("dd.MM.yyyy"),
                    rdr.GetDateTime(4).ToString("dd.MM.yyyy"), rdr.GetString(5), rdr.GetString(6), rdr.GetDecimal(7).ToString()};
                    //MessageBox.Show(row_d.ToString());
                    FindTabel.Rows.Add(row_d);

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

        private void FindBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindTabel.Rows.Clear();
            if (ChoiceBox.Text == "loginie") FoundLogin(FindBox.Text);
            else if (ChoiceBox.Text == "nr roweru") FoundBike(FindBox.Text);
            else if (ChoiceBox.Text == "miejscu") FoundPlace(FindBox.Text);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {

        }
    }


}

