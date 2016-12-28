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
        private int number = 0;
        private string place = "";
        private string user_login = "";
        private bool rent = false;
        public EditBikeForm(MySqlDataReader rdr)
        {
            InitializeComponent();
            ImportData(rdr);
            rdr.Close();
            EdBikeNumTBox.Text = number.ToString();
            if (rent)
            {
                RentYesRButton.Checked = true;
                RentNoRButton.Checked = false;
            }
            else
            {
                RentNoRButton.Checked = true;
                RentYesRButton.Checked = false;
            }
        }

        private void ImportData(MySqlDataReader rdr)
        {
            number = rdr.GetInt32(3);
            if (rdr.GetInt16(4) == 1) rent = true;
            else rent = false;
        }

        private bool b_nr = false, b_rent = false, b_place = false, b_user = false,b_status=false;

        private void EditBike()
        {
            if (!b_nr && !b_place && !b_rent && !b_user) MessageBox.Show("Nic nie zostało zmienione", "Info");
            else
            {
                try
                {
                    string edit_query = "UPDATE rowery SET ";
                    if (b_user)
                    {
                        edit_query += "id_uzytkownik='" + EdBikeUsLoginCBox.Text + "' ";
                        if (b_place || b_nr || b_rent || b_status) edit_query += ", ";
                        b_user = false;
                    }
                    if (b_place)
                    {
                        edit_query += "id_miejsca='" + EdBikePlaceCBox.Text + "' ";
                        if (b_nr || b_rent || b_status) edit_query += ", ";
                        b_place = false;
                    }
                    if (b_nr)
                    {
                        edit_query += "numer='" + EdBikeNumTBox.Text + "' ";
                        if (b_rent || b_status) edit_query += ", ";
                        b_nr = false;
                        edited = true;
                    }
                    if (b_rent)
                    {
                        int temp = 0;
                        if (RentYesRButton.Checked) temp = 1;
                        edit_query += "wypozyczony='" + temp.ToString() + "' ";
                        if (b_status) edit_query += ", ";
                        b_rent = false;
                    }
                    if (b_status)
                    {
                        edit_query += "stan='" /*+ tutaj cos*/ + "' ";
                        b_status = false;
                    }
                    edit_query += "WHERE numer='" + number + "';";
                    MySqlCommand updateCmd = new MySqlCommand(edit_query, Form1.connection);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Edytowano dane roweru", "Gratulacje");
                    number = Int32.Parse(EdBikeNumTBox.Text);
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
            if (number == Int32.Parse(EdBikeNumTBox.Text)) b_status = false;
            else b_status = true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            EditBike();
            this.Close();
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

        private void EdBikeUsLoginCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user_login == EdBikeUsLoginCBox.Text) b_user = false;
            else b_user = true;
        }

        private void RentYesRButton_CheckedChanged(object sender, EventArgs e)
        {
            bool temp = RentYesRButton.Checked;
            //warunek czy zaszła zmiana względem wejścia
            if (rent == temp) b_rent = false;
            else b_rent = true;
        }

        private void RentNoRButton_CheckedChanged(object sender, EventArgs e)
        {
            //bool temp=RentNoRButton.Checked
            //warunek czy zaszła zmiana względem wejścia
        }
    }
}