using bankapplicationc.classes;
using bankapplicationc_.classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankapplicationc_
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
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

        private void Form10_Load(object sender, EventArgs e)
        {
            GetAccountNumber();

        }
        private void comboBox1_SelectedIndexChanged()
        {
            int selectedAccountNumber = int.Parse(comboBox1.Text);
            GetAccountNumberForComboBox2(selectedAccountNumber);
        }





        private void button1_Click(object sender, EventArgs e)
        {
            GetAccountInfo();
            comboBox1_SelectedIndexChanged();


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
        public void GetAccountNumberForComboBox2(int selectedAccountNumber)
        {
            using (var db = new BankDbContext())
            {
                // Accounta tablosundaki AccountNumber alanını çekiyoruz
                var accountNumbers = db.Accounts
                    .Where(a => a.AccountNumber != selectedAccountNumber) // Seçilen öğeyi hariç tut
                    .Select(a => a.AccountNumber)
                    .ToList();
                // ComboBox'ı verilerle dolduruyoruz
                comboBox2.DataSource = accountNumbers;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAccountInfo1();
        }
        public void GetAccountInfo1()
        {
            using (var db = new BankDbContext())
            {
                var q = from a in db.Accounts
                        where a.AccountNumber == int.Parse(comboBox2.Text)
                        select new { customername = a.CustomerName, accounttype = a.AccountType, currentbalance = a.Balance };

                foreach (var item in q)
                {
                    textBox5.Text = item.customername.ToString();
                    textBox6.Text = item.accounttype.ToString();
                    textBox7.Text = item.currentbalance.ToString();
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            
                using (var db = new BankDbContext())
                {
                    var accountnumber = int.Parse(comboBox1.Text);
                    var account = db.Accounts.SingleOrDefault(a => a.AccountNumber == accountnumber);
                    var sourceaccount = from a in db.Accounts
                            where a.AccountNumber == int.Parse(comboBox1.Text)
                            select new { customerid = a.CustomerID, accounttype = a.AccountType, currentbalance = a.Balance };
                    var destinationaccount = from a in db.Accounts
                                        where a.AccountNumber == int.Parse(comboBox2.Text)
                                        select new { customerid = a.CustomerID, accounttype = a.AccountType, currentbalance = a.Balance };

                    var sourceAccountID = sourceaccount.FirstOrDefault().customerid;
                    var destinationAccountID = destinationaccount.FirstOrDefault().customerid;
                    var amount = float.Parse(textBox4.Text);
                    var transactionlog = new TransactionLog
                    {
                        AccountID = account.AccountID, // Burada account, çekilen hesabın ilgili Account nesnesidir.
                        CustomerID = account.CustomerID,
                        TransactionLogDate = DateTime.Now,
                        OperationType = "Money Transfer Between Accounts",
                        Amount = -amount
                    };
                    db.TransactionLogs.Add(transactionlog);
                    db.SaveChanges();
                    if (amount<= sourceaccount.FirstOrDefault().currentbalance)
                    {
                        var transfer = new Transfer
                        {
                            SourceAccountID = sourceAccountID,
                            DestinationAccountID = destinationAccountID,
                            Amount = amount,
                            TransferDate = DateTime.Now,
                            TransactionLogId = transactionlog.Id
                            // Diğer gerekli özellikleri de ekleyebilirsiniz.
                        };
                        db.Transfers.Add(transfer);
                        var azalanaccount = db.Accounts.SingleOrDefault(a => a.AccountID == sourceAccountID);
                        azalanaccount.Balance -= amount;
                        var artanaccount = db.Accounts.SingleOrDefault(a => a.AccountID == destinationAccountID);
                        artanaccount.Balance += amount;
                        MessageBox.Show("The money transfer was successful.");
                    }
                    else
                    {
                        MessageBox.Show("The account that sent the money does not have this much money in its balance.");
                    }
               
                
                    db.SaveChanges();
                }
                GetAccountInfo();
                GetAccountInfo1();
                textBox4.Clear();
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
