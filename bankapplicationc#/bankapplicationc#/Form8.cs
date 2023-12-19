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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            GetAccountInfo();
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
                    textBox1.Text = item.customername.ToString();
                    textBox2.Text = item.accounttype.ToString();
                    textBox3.Text = item.currentbalance.ToString();
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
                    var eksilecekpara = float.Parse(textBox4.Text);
                    var amount=-eksilecekpara;
                    if (account.Balance >= eksilecekpara)
                    {
                        account.Balance -= eksilecekpara;
                        MessageBox.Show("Withdrawal was successful");
                    }
                    else
                    {
                        MessageBox.Show("Insufficient funds");
                    }
                    var transactionlog = new TransactionLog
                    {
                        AccountID = account.AccountID, // Burada account, çekilen hesabın ilgili Account nesnesidir.
                        CustomerID = account.CustomerID,
                        TransactionLogDate = DateTime.Now,
                        OperationType = "Withdrawal",
                        Amount = float.Parse(textBox4.Text)
                    };
                    db.TransactionLogs.Add(transactionlog);
                    db.SaveChanges();
                    GetAccountInfo();
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}




