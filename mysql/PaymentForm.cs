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
    public partial class PaymentForm : Form
    {
        private string login = "",form_name="";
        private int id_user = 0;
        private DateTime from_date, to_date;
        public PaymentForm(int id,string n,string f1)
        {
            InitializeComponent();
            login=n;
            id_user=id;
            ToDateForm.Value = DateTime.Now;
            to_date = ToDateForm.Value;
            TimeSpan ts = new TimeSpan(30, 0, 0, 0,0);
            from_date = to_date - ts;
            FromDateBox.Value = from_date;
            UserLogin.Text += login;
            this.Text = f1;
            form_name = f1;
            if(form_name=="Wyświetlanie płatności")
            {
                DataBox.ReadOnly = true;
                OKButton.Hide();
                ApplyButton.Hide();
                CancelButton.Text = "OK";
            }
            
            //UpdateData();
        }

        private void UpdateData()
        {
            string str_to_date = to_date.ToString("yyyy-MM-dd HH:mm:ss");
            string str_from_date = from_date.ToString("yyyy-MM-dd HH:mm:ss");
            //MessageBox.Show("Updating data");
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM wplaty WHERE id_uzytkownik='" + id_user.ToString() + "' AND (data_wplaty BETWEEN '"+str_from_date+"' AND '"+str_to_date+"');", Form1.connection);
                //MessageBox.Show("Od:"+str_from_date,"do:"+str_to_date);
                //MySqlCommand cmd = new MySqlCommand("SELECT * FROM wplaty WHERE id_uzytkownik='" + id_user + "';", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                //tutaj uzupełnianie tabelki, nie wchodzi do pętli
                while (rdr.Read())
                {
                    //MessageBox.Show("hello");
                    DataBox.ColumnCount = 3;
                    DataBox.ColumnHeadersVisible = true;

                    // Set the column header style.
                    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

                    columnHeaderStyle.BackColor = Color.Beige;
                    columnHeaderStyle.Font = new Font("Verdana", 7, FontStyle.Regular);
                    DataBox.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                    // Set the column header names.
                    DataBox.Columns[0].Name = "ID";
                    DataBox.Columns[1].Name = "Wartość wpłaty";
                    DataBox.Columns[2].Name = "Data wpłaty";

                    //utworzenie wpisu w wiersz i umieszczenie w tabeli
                    string[] row_d = new string[] { rdr.GetInt32(0).ToString(), rdr.GetDecimal(2).ToString(), rdr.GetDateTime(3).ToString("dd.MM.yyyy HH:mm:ss") };
                    //MessageBox.Show(row_d.ToString());
                    DataBox.Rows.Add(row_d);

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

        private void EditPayment()
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            EditPayment();
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            EditPayment();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FromDateBox_ValueChanged(object sender, EventArgs e)
        {
            from_date = FromDateBox.Value;
            DataBox.Rows.Clear();
            UpdateData();
        }

        private void ToDateForm_ValueChanged(object sender, EventArgs e)
        {
            to_date = ToDateForm.Value;
            DataBox.Rows.Clear();
            UpdateData();
        }
    }
}
