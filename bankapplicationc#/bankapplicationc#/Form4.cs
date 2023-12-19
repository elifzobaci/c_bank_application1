using bankapplicationc_.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace bankapplicationc_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            using (var db = new BankDbContext())
            {
                // Veritabanından müşteri bilgilerini al
                var query0 = from c in db.Customers
                             select new { c.CustomerName, c.AccountNumber, c.AccountType, c.Email, c.PhoneNumber, c.SSN };



                // DataGridView'e müşteri bilgilerini ekle
                dataGridView1.DataSource = query0.ToList();
               
                dataGridView1.Columns["CustomerName"].Width = 250; // Örnek bir genişlik
                dataGridView1.Columns["AccountNumber"].Width = 250;
                dataGridView1.Columns["AccountType"].Width = 200;
                dataGridView1.Columns["Email"].Width = 300;
                dataGridView1.Columns["PhoneNumber"].Width = 200;
                dataGridView1.Columns["SSN"].Width = 200;



            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (var db = new BankDbContext())
            {
                if (comboBox1.Text == "Customername")
                {
                    var query = from c in db.Customers
                                where c.CustomerName.Contains(textBox1.Text)
                                select new { c.CustomerName, c.AccountNumber, c.AccountType, c.Email, c.PhoneNumber, c.SSN };
                    dataGridView1.DataSource=query.ToList();
                    dataGridView1.Columns["CustomerName"].Width = 250; // Örnek bir genişlik
                    dataGridView1.Columns["AccountNumber"].Width = 250;
                    dataGridView1.Columns["AccountType"].Width = 200;
                    dataGridView1.Columns["Email"].Width = 300;
                    dataGridView1.Columns["PhoneNumber"].Width = 200;
                    dataGridView1.Columns["SSN"].Width = 200;
                }
                else if(comboBox1.Text == "Account Number")
                {
                    var query = from c in db.Customers
                                where c.AccountNumber.ToString().Contains(textBox1.Text)
                                select new { c.CustomerName, c.AccountNumber, c.AccountType, c.Email, c.PhoneNumber, c.SSN };
                    dataGridView1.DataSource = query.ToList();
                    dataGridView1.Columns["CustomerName"].Width = 250; // Örnek bir genişlik
                    dataGridView1.Columns["AccountNumber"].Width = 250;
                    dataGridView1.Columns["AccountType"].Width = 200;
                    dataGridView1.Columns["Email"].Width = 300;
                    dataGridView1.Columns["PhoneNumber"].Width = 200;
                    dataGridView1.Columns["SSN"].Width = 200;
                }
           
            }

        }
    }
}
