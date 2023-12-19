using bankapplicationc.classes;
using bankapplicationc_.classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bankapplicationc_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            occupationtxt.Leave -= occupationtxt_Leave;
            phonenumbertxt.Leave -= phonenumbertxt_Leave;
            // Diğer Leave olaylarını da devre dışı bırakabilirsiniz.
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            occupationtxt.Leave += occupationtxt_Leave;
            // Diğer Leave olaylarını da tekrar etkinleştirebilirsiniz.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            customernametxt.Select();
            radioButton1.Select();
            UretVeYazdir();
            accountnumbertxt.Enabled = false;
        }
        private void UretVeYazdir()
        {
            // Rastgele 12 haneli sayı üret
            Random random = new Random();
            long rastgeleSayi = (long)random.Next(10000000, 99999999);



            // TextBox'a yazdır
            accountnumbertxt.Text = rastgeleSayi.ToString();
        }
        private void Form3_Leave(object sender, EventArgs e)
        {

        }



        private void customernametxt_Leave(object sender, EventArgs e)
        {

        }






        private void customernametxt_Leave_1(object sender, EventArgs e)
        {
            //try
            //{
            //    somekontrols isimkontrol = new somekontrols();
            //    isimkontrol.setmusteriadi(customernametxt.Text);
            //    label12.Visible = true;
            //    label12.Text = "Customer Name in Correct Format";
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show("There cannot be any characters other than letters and spaces in the customer name !");
            //    customernametxt.Clear();
            //    label12.Visible = false;
            //    customernametxt.Select();
            //}
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BankDbContext())
                {
                    db.Database.EnsureCreated();
                    var customername = customernametxt.Text;
                    var accountnumber = int.Parse(accountnumbertxt.Text);
                    var accounttype = accounttypecmbbx.Text;
                    //var gender için asagidakileri yazdık.
                    var gender = "";  // gender değişkenini burada tanımladık ve başlangıç değeri atadık

                    if (radioButton1.Checked)
                    {
                        gender = radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        gender = radioButton2.Text;
                    }
                    else if (radioButton3.Checked)
                    {
                        gender = radioButton3.Text;
                    }
                    var dateofbirth = dateTimePicker1.Value;
                    var nationality = nationalitycmbbx.Text;
                    var email = emailadrestxt.Text;
                    var phonenumber = phonenumbertxt.Text;
                    var ssn = ssntxt.Text;
                    var occupation = occupationtxt.Text;
                    var customer = new Customer
                    {
                        CustomerName = customername,
                        AccountNumber = accountnumber,
                        AccountType = accounttype,
                        Gender = gender,
                        DateofBirth = dateofbirth,
                        Nationality = nationality,
                        Email = email,
                        PhoneNumber = phonenumber,
                        SSN = ssn,
                        Occupation = occupation,
                    };
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    // Eklenen müşterinin CustomerID değerini al
                    var customerId = customer.CustomerID;
                    var account = new Account
                    {
                        AccountNumber = accountnumber,
                        AccountType = accounttype,
                        CustomerName = customername,
                        Balance = 50,
                        //For open an account you should give 50 USD
                        CustomerID = customerId, // Eklediğiniz müşterinin CustomerID değerini atayın
                    };
                    //var transactionlog = new TransactionLog
                    //{
                    //    TransactionLogDate = DateTime.Now,
                    //    OperationType = "Account Opening",
                    //    Amount = +50

                    //}; 
                    db.Accounts.Add(account);
                    //db.TransactionLogs.Add(transactionlog);
                    db.SaveChanges();
                    MessageBox.Show("Added New Customer successfully ");
                    customernametxt.Clear();
                    accounttypecmbbx.SelectedIndex = -1;
                    dateTimePicker1.Value = DateTime.Now;
                    nationalitycmbbx.SelectedIndex = -1;
                    emailadrestxt.Clear();
                    phonenumbertxt.Clear();
                    ssntxt.Clear();
                    occupationtxt.Clear();
                    UretVeYazdir();
                };
            }
            catch (Exception ex)
            {

                StringBuilder message = new StringBuilder();
                message.AppendLine("An error occurred while saving the entity changes.");

                Exception innerException = ex;
                while (innerException != null)
                {
                    message.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }

                MessageBox.Show(message.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using (var context = new BankDbContext())
            //{
            //    var customerImage = new CustomerImage
            //    {
            //        Image = 
            //    };

            //    context.CustomerImages.Add(customerImage);
            //    context.SaveChanges();
            //}
        }

        private void emailadrestxt_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    somekontrols email = new somekontrols();
            //    email.setemail(emailadrestxt.Text);
            //    label16.Visible = true;
            //    label16.Text = "E-mail in Correct Format";
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show("The e-mail format is incorrect. Please enter in the correct format.");
            //    emailadrestxt.Clear();
            //    label16.Visible=false;
            //    emailadrestxt.Select();
            //}
        }

        private void occupationtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void occupationtxt_Leave(object sender, EventArgs e)
        {
            try
            {
                somekontrols occupationkontrol = new somekontrols();
                occupationkontrol.setmusteriadi(occupationtxt.Text);
                label13.Visible = true;
                label13.Text = "Occupation in Correct Format";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("There cannot be any characters other than letters and spaces in the occupation !");
                occupationtxt.Clear();
                label13.Visible = false;
                occupationtxt.Select();
            }
        }

        private void phonenumbertxt_Leave(object sender, EventArgs e)
        {
            try
            {
                somekontrols phonenumberkontrol = new somekontrols();
                phonenumberkontrol.setphoneNumber(phonenumbertxt.Text);
                label14.Visible = true;
                label14.Text = "Phone Number Format is correct";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Phone number format is incorrect. Please enter again!");
                phonenumbertxt.Clear();
                label14.Visible = false;
                phonenumbertxt.Select();
            }
        }

        private void ssntxt_Leave(object sender, EventArgs e)
        {
            try
            {
                somekontrols ssn = new somekontrols();
                ssn.setssn(ssntxt.Text);
                label15.Visible = true;
                label15.Text = "SSN Format is correct.";
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
                ssntxt.Clear();
                label15.Visible = false;
                ssntxt.Select();
            }
        }
    }


}

