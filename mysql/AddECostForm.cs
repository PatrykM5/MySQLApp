﻿using System;
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
    public partial class AddECostForm : Form
    {
        private int id_user;
        private int id_cost;
        private string login;
        private decimal money,topay=0;
        private DateTime date;
        private bool paid,paid_old;
        private string description="";
        private string date_temp = "";
        private int choice = 0;
        private bool b_money = false, b_date = false, b_paid = false, b_desc = false;
        private bool now = true;

        public AddECostForm(int id,string n,string formname)
        {
            InitializeComponent();
            id_user = id;
            login = n;
            this.Text = formname;
            if (formname == "Dodawanie kosztu dodatkowego")
            {
                NoRButton.Checked = true;
                paid = false;
                IDComboBox.Hide();
                IDLabel.Hide();
                PayInfo(id);
                DateCheckBox.Checked = true;
                choice = 1;
            }
            else if (formname == "Wyświetlanie kosztów dodatkowych")
            {
                UpdateData(id);
                DescriptionBox.Enabled = false;
                MoneyBox.Enabled = false;
                DateBox.Enabled = false;
                YesRButton.Enabled = false;
                NoRButton.Enabled = false;
                ApplyButton.Hide();
                OKButton.Hide();
                CancelButton.Text = "OK";
                DateCheckBox.Hide();
                DateBox.Format=DateTimePickerFormat.Custom;
                DateBox.CustomFormat = "dd.MM.yyyy HH:mm";
                choice = 2;
            }
            else if(formname=="Edycja kosztów dodatkowych")
            {
                UpdateData(id);
                ApplyButton.Text = "Zastosuj zmiany";
                now = false;
                DateCheckBox.Checked = false;
                choice = 3;
            }
        }

        private void UpdateData(int id)
        {
            //int temp_b;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM koszty_dodatkowe WHERE id_uzytkownik='" + id + "';", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.GetInt16(5) == 0) topay += rdr.GetDecimal(2);
                    id_cost = rdr.GetInt32(0);
                    IDComboBox.Items.Add(id_cost);
                    //id_user = rdr.GetInt16(1);
                    //money = rdr.GetFloat(2);
                    //MoneyBox.Value = (decimal)money;
                    //date_temp = rdr.GetString(3);
                    //MessageBox.Show(date_temp);
                    //description = rdr.GetString(4);
                    //DescriptionBox.Text = description;
                    //temp_b = rdr.GetInt16(5);
                    //if (temp_b == 0) NoRButton.Checked = true;
                    //else YesRButton.Checked = true;
                    while (rdr.Read())
                    {
                        IDComboBox.Items.Add(rdr.GetString(0));
                        if(rdr.GetInt16(5)==0) topay+=rdr.GetDecimal(2);
                    }
                    rdr.Close();
                    ToPayLabel.Text = "Do zapłacenia przez użytkownika: " + topay.ToString();
                    IDComboBox.SelectedIndex=IDComboBox.FindStringExact(id_cost.ToString());
                } else
                {
                    rdr.Close();
                    MessageBox.Show("Brak kosztów dodatkowych użytkownika", "Informacja");
                    //Close();
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

        private void PayInfo(int id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM koszty_dodatkowe WHERE id_uzytkownik='" + id + "';", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.GetInt16(5) == 0) topay += rdr.GetDecimal(2);
                    
                    while (rdr.Read())
                    {
                        
                        if (rdr.GetInt16(5) == 0) topay += rdr.GetDecimal(2);
                    }
                    rdr.Close();
                    
                }
                else rdr.Close();
                ToPayLabel.Text = "Do zapłacenia przez użytkownika: " + topay.ToString();
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

        private void AddECost()
        {
            int temp_b = 0;
            money = MoneyBox.Value;
            if (now) date = DateTime.Now;
            else date = DateBox.Value;
            string formatForMySql = date.ToString("yyyy-MM-dd HH:mm:ss");
            if (paid) temp_b = 1;
            description = DescriptionBox.Text;
            if (description == "") MessageBox.Show("Dodaj opis kosztu", "Błąd");
            else {
                try
                {
                    string insert_query = "INSERT INTO koszty_dodatkowe (id_uzytkownik,kwota,data_koszt,opis,zaplacone) VALUES ('" + id_user + "','" + money + "','" + formatForMySql + "', '" + description + "', '" + temp_b + "')";
                    MySqlCommand updateCmd = new MySqlCommand(insert_query, Form1.connection);
                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano koszt", "Gratulacje");
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

        private void EditECost()
        {
            decimal temp_d=money;
            if (!b_money && !b_date && !b_desc && !b_paid) MessageBox.Show("Nic nie zostało zmienione", "Info");
            else
            {
                try
                {
                    string edit_query = "UPDATE koszty_dodatkowe SET ";
                    if (b_money)
                    {
                        string temp_mon=MoneyBox.Value.ToString();
                        StringBuilder S = new StringBuilder(temp_mon);
                        S.Replace(",", ".");
                        temp_mon = S.ToString();
                        //MessageBox.Show(temp_mon);
                        edit_query += "kwota='" + temp_mon+"'";
                        if (b_date || b_desc || b_paid) edit_query += ", ";
                        //temp_d= money;
                        money = MoneyBox.Value;
                    }
                    if (b_date)
                    {
                        if (now) date = DateTime.Now;
                        else date = DateBox.Value;
                        string formatForMySql = date.ToString("yyyy-MM-dd HH:mm:ss");
                        edit_query += "data_koszt='" + formatForMySql+"' ";
                        if (b_desc || b_paid) edit_query += ", ";
                        b_date = false;
                    }
                    if (b_desc)
                    {
                        edit_query += "opis='" + DescriptionBox.Text+"'";
                        if (b_paid) edit_query += ", ";
                        b_desc = false;
                        description = DescriptionBox.Text;
                    }
                    if (b_paid)
                    {
                        int temp;
                        if (NoRButton.Checked)
                        {
                            temp = 0;
                            paid = false;
                            topay += temp_d;
                        }
                        else { temp = 1; paid = true; topay -= temp_d; }
                        edit_query += "zaplacone=" + temp.ToString();
                        paid_old = paid;
                    }
                    edit_query += " WHERE id_koszt='" + id_cost.ToString() + "';";
                    MySqlCommand updateCmd = new MySqlCommand(edit_query, Form1.connection);
                    updateCmd.ExecuteNonQuery();
                    if (b_money)
                    {
                        topay -= temp_d;
                        topay += money;
                        if(!paid) ToPayLabel.Text = "Do zapłacenia przez użytkownika: " + topay.ToString();
                        b_money = false;
                    }
                    if (b_paid)
                    {
                        ToPayLabel.Text = "Do zapłacenia przez użytkownika: " + topay.ToString();
                        b_paid = false;
                    }
                    MessageBox.Show("Edytowano dane kosztu", "Gratulacje");
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

        private void AddECostForm_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (choice == 1) AddECost();
            else if (choice == 3) EditECost();
            this.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (choice == 1) AddECost();
            else if (choice == 3) EditECost();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            if (description == DescriptionBox.Text) b_desc = false;
            else b_desc = true;
        }

        private void MoneyBox_ValueChanged(object sender, EventArgs e)
        {
            if ((decimal)money == MoneyBox.Value) b_money = false;
            else b_money = true;
        }

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DateCheckBox.Checked)
            {
                now = true;
                DateBox.Enabled = false;
                b_date = true;
            }
            else {
                now = false;
                DateBox.Enabled = true;
                if (date == DateBox.Value) b_date = false;
                else b_date = true;
            }
        }

        private void DateBox_ValueChanged(object sender, EventArgs e)
        {
            if (date == DateBox.Value) b_date = false;
            else b_date = true;
        }

        private void NoRButton_CheckedChanged(object sender, EventArgs e)
        {
            bool tempN = NoRButton.Checked;
            if (tempN)
            {
                paid = false;
                //MessageBox.Show("zmiana N");
                if (paid_old == paid) b_paid = false;
                else b_paid = true;
            }
        }

        private void YesRButton_CheckedChanged(object sender, EventArgs e)
        {
            bool tempY = YesRButton.Checked;
            if (tempY)
            {
                paid = true;
                //MessageBox.Show("zmiana Y");
                if (paid_old == paid) b_paid = false;
                else b_paid = true;
            }
        }

        private void ChangedID(string id_s)
        {
            int temp_b;
            //MessageBox.Show(id_s);
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM koszty_dodatkowe WHERE id_uzytkownik='" + id_user + "' AND id_koszt='"+id_s+"';", Form1.connection);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    id_cost = rdr.GetInt16(0);
                    money = rdr.GetDecimal(2);
                    MoneyBox.Value = (decimal)money;
                    date_temp = rdr.GetString(3);
                    //MessageBox.Show(date_temp);
                    date = Convert.ToDateTime(date_temp);
                    //MessageBox.Show(dt.ToString());
                    DateBox.Value = date;
                    description = rdr.GetString(4);
                    DescriptionBox.Text = description;
                    temp_b = rdr.GetInt16(5);
                    if (temp_b == 1) { YesRButton.Checked = true; paid = true; }
                    else { NoRButton.Checked = true; paid = false; }
                    paid_old = paid;
                    rdr.Close();
                }
                else
                {
                    rdr.Close();
                    MessageBox.Show("Coś poszło nie tak", "Błąd");
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

        private void IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedID(IDComboBox.SelectedItem.ToString());
        }
    }
}
