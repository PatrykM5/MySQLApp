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
    public partial class EditBikeForm : Form
    {
        public bool edited = false;
        private int id = 0;
        private int number = 0;
        private int id_place = 0;
        private int id_user = 0;
        private string place = "";
        private string user_login = "";
        private string status = "";
        private bool rent = false;
        private bool edit_mode = true;
        public EditBikeForm(MySqlDataReader rdr,string formname)
        {
            InitializeComponent();
            this.Text = formname;
            if(formname=="Wyświetl dane roweru")
            {
                EdBikeNumTBox.Enabled = false;
                EdBikePlaceCBox.Enabled = false;
                RentYesRButton.Enabled = false;
                RentNoRButton.Enabled = false;
                EdBikeUsLoginCBox.Enabled = false;
                BikeStatusBox.Enabled = false;
                OKButton.Hide();
                EditBikeButton.Hide();
                CancelButton.Text = "OK";
                edit_mode = false;
            }
            ImportData(rdr);
            rdr.Close();
            AddAllPlaces();
            IDLabel.Text += "  " + id;
            EdBikeNumTBox.Text = number.ToString();
            if (rent)
            {
                RentYesRButton.Checked = true;
                RentNoRButton.Checked = false;
                //EdBikeUsLoginCBox.Enabled = true;
                AddAllUsers();
                SelectUser(id_user);
                EdBikeUsLoginCBox.SelectedIndex = EdBikeUsLoginCBox.FindStringExact(user_login);
            }
            else
            {
                RentNoRButton.Checked = true;
                RentYesRButton.Checked = false;
                EdBikeUsLoginCBox.Enabled = false;
            }
            //tutaj jeszcze powinno wybrać miejsce?
            SelectPlace(id_place);
            EdBikePlaceCBox.SelectedIndex = EdBikePlaceCBox.FindStringExact(place);
            BikeStatusBox.SelectedIndex = BikeStatusBox.FindStringExact(status);
        }

        private void ImportData(MySqlDataReader rdr)
        {
            id = rdr.GetInt32(0);
            number = rdr.GetInt32(3);
            status = rdr.GetString(5);
            if (rdr.GetInt16(4) == 1) rent = true;
            else rent = false;
            try {
                id_place = rdr.GetInt32(2);
                //MessageBox.Show(id_place.ToString(), "ID miejsca");
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.ToString(), "ERROR");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "ERROR");
            }
            if (rent)
            {
                try {
                    id_user = rdr.GetInt32(1);
                }
                catch (MySqlException ex)
                {
                    //MessageBox.Show(ex.ToString(), "ERROR");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }

        private void AddAllPlaces()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EdBikePlaceCBox.Items.Add(rdr.GetString(1));
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

        private void SelectPlace(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE id_miejsca="+id.ToString(), Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    place = rdr.GetString(1);
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
        }

        private void FindPlace(string name)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM miejsca WHERE nazwa='" + name+"'", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    id_place = rdr.GetInt16(0);
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
        }

        private void AddAllUsers()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EdBikeUsLoginCBox.Items.Add(rdr.GetString(1));
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

        private void SelectUser(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE id_uzytkownik=" + id.ToString(), Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    user_login = rdr.GetString(1);
                }
                else
                {
                    MessageBox.Show("Brak uzytkownika", "Info");
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

        private void FindUser(string name)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM uzytkownik WHERE login='" + name + "'", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    id_user = rdr.GetInt16(0);
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
        }

        private bool b_nr = false, b_rent = false, b_place = false, b_user = false,b_status=false;

        private void EditBike()
        {
            if (!b_nr && !b_place && !b_rent && !b_user &&!b_status) MessageBox.Show("Nic nie zostało zmienione", "Info");
            else
            {
                try
                {
                    string edit_query = "UPDATE rowery SET ";
                    int temp = 0;
                    if (RentYesRButton.Checked) { temp = 1; rent = true; }
                    else rent = false;
                    if (rent && EdBikeUsLoginCBox.Text == "")
                    {
                        MessageBox.Show("Gdy rower jest wypożyczony musi mieć użytkownika", "Błąd");
                    }
                    else {
                        if (b_user)
                        {
                            //turaj znajdowanie które id wybrac na podstawie loginu
                            FindUser(EdBikeUsLoginCBox.Text);
                            edit_query += "id_uzytkownik='" + id_user + "' ";
                            if (b_place || b_nr || b_rent || b_status) edit_query += ", ";
                            b_user = false;
                            user_login = EdBikeUsLoginCBox.Text;
                        }
                        if (b_place)
                        {
                            //tutaj znajdowanie które id wybrać na podstawie miejsca
                            FindPlace(EdBikePlaceCBox.Text);
                            edit_query += "id_miejsca='" + id_place + "' ";
                            if (b_nr || b_rent || b_status) edit_query += ", ";
                            b_place = false;
                            place = EdBikePlaceCBox.Text;
                        }
                        if (b_nr)
                        {
                            edit_query += "numer=" + EdBikeNumTBox.Text + " ";
                            if (b_rent || b_status) edit_query += ", ";
                            b_nr = false;
                            edited = true;
                        }
                        if (b_rent)
                        {
                            edit_query += "wypozyczony='" + temp.ToString() + "' ";
                            if (b_status) edit_query += ", ";
                            b_rent = false;
                        }
                        if (b_status)
                        {
                            edit_query += "stan='" + BikeStatusBox.Text + "' ";
                            b_status = false;
                            //tutaj jeszcze zmiana stanu
                            status = BikeStatusBox.Text;
                        }
                        edit_query += "WHERE numer='" + number + "';";
                        MySqlCommand updateCmd = new MySqlCommand(edit_query, Form1.connection);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Edytowano dane roweru", "Gratulacje");
                        number = Int32.Parse(EdBikeNumTBox.Text);
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
        }

        private void EditBikeButton_Click(object sender, EventArgs e)
        {
            EditBike();
        }

        private void EdBikeNumTBox_TextChanged(object sender, EventArgs e)
        {
            if (number == Int32.Parse(EdBikeNumTBox.Text)) b_nr = false;
            else b_nr = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            EditBike();
            if(rent && EdBikeUsLoginCBox.Text != "") this.Close();
            if (!rent) this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EdBikePlaceCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (place == EdBikePlaceCBox.Text) b_place = false;
            else b_place = true;
        }

        private void BikeStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status == BikeStatusBox.Text) b_status = false;
            else b_status = true;
        }

        private void EdBikeUsLoginCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_login == EdBikeUsLoginCBox.Text) b_user = false;
            else b_user = true;
        }

        private bool rent_ch = false;

        private void RentYesRButton_CheckedChanged(object sender, EventArgs e)
        {
            bool temp = RentYesRButton.Checked;
            //warunek czy zaszła zmiana względem wejścia
            if (rent == temp) b_rent = false;
            else b_rent = true;
            if (temp)
            {
                if(edit_mode) EdBikeUsLoginCBox.Enabled = true;
                if (rent_ch)
                {
                    EdBikeUsLoginCBox.Items.Clear();
                    AddAllUsers();
                }
            }
        }

        private void RentNoRButton_CheckedChanged(object sender, EventArgs e)
        {
            bool temp = RentNoRButton.Checked;
            if (temp)
            {
                EdBikeUsLoginCBox.Items.Clear();
                EdBikeUsLoginCBox.Enabled = false;
                rent_ch = true;
            }
            //warunek czy zaszła zmiana względem wejścia
        }
    }
}