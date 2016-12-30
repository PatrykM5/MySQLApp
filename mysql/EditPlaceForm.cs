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
    public partial class EditPlaceForm : Form
    {
        private string name = "";
        private int id = 0;
        public bool edited = false;
        private bool b_name = false;
        public EditPlaceForm(MySqlDataReader rdr)
        {
            InitializeComponent();
            id = rdr.GetInt16(0);
            name = rdr.GetString(1);
            PlaceNameBox.Text = name;
            rdr.Close();
        }

        private void EditPlace()
        {
            if (!b_name) MessageBox.Show("Nic nie zostało zmienione", "Info");
            else
            {
                edited = true;
                try
                {
                    string edit_query = "UPDATE miejsca SET nazwa='"+PlaceNameBox.Text+"' ";
                    edit_query += "WHERE id_miejsca='" + id.ToString()+ "';";
                    MySqlCommand updateCmd = new MySqlCommand(edit_query, Form1.connection);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Edytowano dane miejsca", "Gratulacje");
                    name = PlaceNameBox.Text;
                    b_name = false;
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            EditPlace();
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            EditPlace();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlaceNameBox_TextChanged(object sender, EventArgs e)
        {
            if (name == PlaceNameBox.Text) b_name = false;
            else b_name = true;
        }
    }
}
