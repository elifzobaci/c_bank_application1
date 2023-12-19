using bankapplicationc.classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace bankapplicationc_
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAccountInfo();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            //comboBox1.Select();
        }

        private void Form7_Load_1(object sender, EventArgs e)
        {
            GetAccountNumber();
        }

        public void GetAccountNumber()
        {
            using (var db = new BankDbContext())
            {
                // Accounta tablosundaki AccountNumber alanını çekiyoruz
                var accountNumbers = db.Accounts.Select(a => a.AccountNumber).ToList();
                // ComboBox'ı verilerle dolduruyoruz
                comboBox1.DataSource = accountNumbers;
            }
        }

        public void GetAccountInfo()
        {
            using (var db = new BankDbContext())
            {
                var q = from a in db.Accounts
                        where a.AccountNumber == int.Parse(comboBox1.Text)
                        select new { customername = a.CustomerName, accounttype = a.AccountType, currentbalance = a.Balance };

                foreach (var item in q)
                {
                    textBox4.Text = item.customername.ToString();
                    textBox5.Text = item.accounttype.ToString();
                    textBox6.Text = item.currentbalance.ToString();
                }
            }
        }

  
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BankDbContext())
                {
                    var accountnumber = int.Parse(comboBox1.Text);
                    var account = db.Accounts.SingleOrDefault(a => a.AccountNumber == accountnumber);
                    var eklenecekpara = float.Parse(textBox7.Text);
                    account.Balance += eklenecekpara;
                    var transactionlog = new TransactionLog
                    {
                        AccountID = account.AccountID, // Burada account, çekilen hesabın ilgili Account nesnesidir.
                        CustomerID = account.CustomerID, 
                        TransactionLogDate = DateTime.Now,
                        OperationType = "Deposit",
                        Amount = float.Parse(textBox7.Text)
                    };
                    db.TransactionLogs.Add(transactionlog); 
                    db.SaveChanges();
                    GetAccountInfo();
                    textBox7.Clear();
                    MessageBox.Show("Deposit Made Successfully");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message);
            }
           
        }
    } 
}



