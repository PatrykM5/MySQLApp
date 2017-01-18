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
    public partial class AddPaymentForm : Form
    {
        private int id_user=0;
        private string name = "";
        private DateTime date;
        private decimal money;
        private bool now = true;
        public AddPaymentForm(int id,string n)
        {
            InitializeComponent();
            id_user = id;
            name = n;
            UserLogin.Text += name;
            DateCheckBox.Checked = true;
            HourBox.Hide();
            MinuteBox.Hide();
            TimeLabel.Hide();
            IDLabel.Hide();
            IDComboBox.Hide();
            hLabel.Hide();
            mLabel.Hide();
        }

        private void AddPayment()
        {
            //bool temp = false;
            money = MoneyBox.Value;
            if (now) date = DateTime.Now;
            else date = DateBox.Value;
            string formatForMySql = date.ToString("yyyy-MM-dd HH:mm:ss");
            //MessageBox.Show(date.ToString("yyyy-MM-dd HH:mm:ss"));
            if (money == 0) MessageBox.Show("Nie podano wartości", "Błąd");
            else //if(temp) //by działało trzeba zmienić warunek!
            {
                try
                {
                    string insert_query = "INSERT INTO wplaty (id_uzytkownik,kwota,data_wplaty) VALUES ('" + id_user + "','" + money + "','" + formatForMySql + "')";
                    MySqlCommand updateCmd = new MySqlCommand(insert_query, Form1.connection);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano wpłatę", "Gratulacje");
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
            AddPayment();
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            AddPayment();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DateCheckBox.Checked)
            {
                now = true;
                DateBox.Enabled = false;
            }
            else {
                now = false;
                DateBox.Enabled = true;
            }
        }

        private void UserLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
