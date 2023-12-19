using bankapplicationc_.classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bankapplicationc_
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            GetCustomerName();
            textBox3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetCustomerInfo();
        }
        public void GetCustomerName()
        {
            using (var db = new BankDbContext())
            {
                // Customers tablosundaki CustomerName alanını çekiyoruz
                var customerNames = db.Customers.Select(c => c.CustomerName).ToList();

                // ComboBox'ı verilerle dolduruyoruz
                comboBox1.DataSource = customerNames;

            }
        }

        public void GetCustomerInfo()
        {
            using (var db = new BankDbContext())
            {
                var query = from c in db.Customers
                            where c.CustomerName == comboBox1.Text
                            select new { accounttype = c.AccountType, email = c.Email, phone = c.PhoneNumber, occupation = c.Occupation };
                foreach (var item in query)
                {
                    textBox3.Text = item.accounttype.ToString();
                    textBox4.Text = item.email.ToString();
                    textBox5.Text = item.phone.ToString();
                    textBox6.Text = item.occupation.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BankDbContext())
                {
                    var customername = comboBox1.Text;
                    var cust = db.Customers.SingleOrDefault(a => a.CustomerName == customername);
                    cust.Email = textBox4.Text;
                    cust.PhoneNumber = textBox5.Text;
                    cust.Occupation = textBox6.Text;
                    db.SaveChanges();
                    MessageBox.Show("Customer updated successfully!");
                    GetCustomerInfo();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            try
            {
                somekontrolsnew TelNo = new somekontrolsnew();
                TelNo.PHONENUMBER = textBox5.Text;
                label3.Visible = true;
                label3.Text = "Phone Number Format is correct";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                textBox5.Clear();
                label3.Visible = false;
                textBox5.Select();
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    somekontrolsnew ocp = new somekontrolsnew();
            //    ocp.OCCUPATION = textBox6.Text;
            //    label9.Visible = true;
            //    label9.Text = "Occupation Format is correct";
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    textBox6.Clear();
            //    label9.Visible = false;
            //    textBox6.Select();
            //}
        }


    }
}