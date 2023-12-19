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

namespace bankapplicationc_
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            using (var db = new BankDbContext())
            {
                // Veritabanından transaction bilgilerini al
                var query0 = from t in db.TransactionLogs
                             join c in db.Customers on t.CustomerID equals c.CustomerID
                             select new { t.AccountID, c.CustomerName, t.TransactionLogDate, t.Amount, t.OperationType };

                // DataGridView'e müşteri bilgilerini ekle
                dataGridView1.DataSource = query0.ToList();
                dataGridView1.Columns["AccountID"].Width = 150; // Örnek bir genişlik
                dataGridView1.Columns["CustomerName"].Width = 250;
                dataGridView1.Columns["TransactionLogDate"].Width = 300;
                dataGridView1.Columns["Amount"].Width = 150;
                dataGridView1.Columns["OperationType"].Width = 300;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new BankDbContext())
            {
                if (comboBox1.Text== "CustomerName")
                {
                    var query0 = from t in db.TransactionLogs
                                 join c in db.Customers on t.CustomerID equals c.CustomerID
                                 where c.CustomerName.Contains(textBox1.Text)
                                 select new { t.AccountID, c.CustomerName, t.TransactionLogDate, t.Amount, t.OperationType };
                    dataGridView1.DataSource = query0.ToList();
                    dataGridView1.Columns["AccountID"].Width = 150; // Örnek bir genişlik
                    dataGridView1.Columns["CustomerName"].Width = 250;
                    dataGridView1.Columns["TransactionLogDate"].Width = 300;
                    dataGridView1.Columns["Amount"].Width = 150;
                    dataGridView1.Columns["OperationType"].Width = 300;
                }
                else if (comboBox1.Text == "OperationType")
                {
                    var query0 = from t in db.TransactionLogs
                                 join c in db.Customers on t.CustomerID equals c.CustomerID
                                 where t.OperationType.Contains(textBox1.Text)
                                 select new { t.AccountID, c.CustomerName, t.TransactionLogDate, t.Amount, t.OperationType };
                    dataGridView1.DataSource = query0.ToList();
                    dataGridView1.Columns["AccountID"].Width = 150; // Örnek bir genişlik
                    dataGridView1.Columns["CustomerName"].Width = 250;
                    dataGridView1.Columns["TransactionLogDate"].Width = 300;
                    dataGridView1.Columns["Amount"].Width = 150;
                    dataGridView1.Columns["OperationType"].Width = 300;
                }
                else if (comboBox1.Text == "TransactionLogDate")
                {
                    var query0 = from t in db.TransactionLogs
                                 join c in db.Customers on t.CustomerID equals c.CustomerID
                                 where t.TransactionLogDate.ToString().Contains(textBox1.Text)
                                 select new { t.AccountID, c.CustomerName, t.TransactionLogDate, t.Amount, t.OperationType };

                    dataGridView1.DataSource = query0.ToList();
                    dataGridView1.Columns["AccountID"].Width = 150; // Örnek bir genişlik
                    dataGridView1.Columns["CustomerName"].Width = 250;
                    dataGridView1.Columns["TransactionLogDate"].Width = 300;
                    dataGridView1.Columns["Amount"].Width = 150;
                    dataGridView1.Columns["OperationType"].Width = 300;
                }
               

            }
        }
    }
}
