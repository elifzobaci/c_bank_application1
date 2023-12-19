using bankapplicationc_.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankapplicationc_
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (var db = new BankDbContext())
            {
                // Veritabanından müşteri bilgilerini al
                var query = from transfer in db.Transfers
                            join sourceAccount in db.Accounts on transfer.SourceAccountID equals sourceAccount.AccountID
                            join destinationAccount in db.Accounts on transfer.DestinationAccountID equals destinationAccount.AccountID
                            select new
                            {
                                TransferID = transfer.TransferID,
                                SourceAccount = sourceAccount.ToString(),
                                DestinationAccount = destinationAccount.ToString(),
                                TransferDate = transfer.TransferDate,
                                Amount = transfer.Amount,
                            };



                // DataGridView'e müşteri bilgilerini ekle
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns["TransferID"].Width = 150; // Örnek bir genişlik
                dataGridView1.Columns["Amount"].Width = 150;
                dataGridView1.Columns["TransferDate"].Width = 200;
                dataGridView1.Columns["SourceAccount"].Width = 250;
                dataGridView1.Columns["DestinationAccount"].Width = 200;



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            
        }
    }
}
