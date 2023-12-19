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

namespace bankapplicationc_
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAccountInfo();
            //UretVeYazdir();
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

        private void Form9_Load(object sender, EventArgs e)
        {
            GetAccountNumber();
            radioButton1.Select();
        }


        private void UretVeYazdir()
        {
            // Rastgele sayı üret
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 100);
            // TextBox'a yazdır
            textBox4.Text = rastgeleSayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UretVeYazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BankDbContext())
                {
                    var accountnumber = comboBox1.Text;
                    var account = db.Accounts.SingleOrDefault(a => a.AccountNumber == int.Parse(accountnumber));
                    var fatura = float.Parse(textBox4.Text);
                    if (account.Balance >= fatura)
                    {
                        account.Balance -= fatura;
                        MessageBox.Show("The invoice has been paid successfully");
                    }
                    else
                    {
                        MessageBox.Show("insufficient funds");
                    }
                    var transactionlog = new TransactionLog
                    {
                        AccountID = account.AccountID, // Burada account, çekilen hesabın ilgili Account nesnesidir.
                        CustomerID = account.CustomerID,
                        TransactionLogDate = DateTime.Now,
                        OperationType = "Pay the Bill",
                        Amount = -fatura
                    };
                    db.TransactionLogs.Add(transactionlog);
                    db.SaveChanges();
                    GetAccountInfo();
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                Exception innerException = ex;
                while (innerException != null)
                {
                    MessageBox.Show("An error occurred: " + innerException.Message);
                    innerException = innerException.InnerException;
                }
            }
        }
    }
}
