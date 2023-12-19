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
    public partial class Form2 : Form
    {
        Form ff;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            ff = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            //this form2 demektir.
            form3.MdiParent = this;
            form3.Show();

            //form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            //this form2 demektir.
            form4.MdiParent = this;
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            //this form2 demektir.
            form5.MdiParent = this;
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form6 form6 = new Form6();
            //this form2 demektir.
            form6.MdiParent = this;
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form7 form7 = new Form7();
            //this form2 demektir.
            form7.MdiParent = this;
            form7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form8 form8 = new Form8();
            //this form2 demektir.
            form8.MdiParent = this;
            form8.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Form9 form9 = new Form9();
            //this form2 demektir.
            form9.MdiParent = this;
            form9.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form10 form10 = new Form10();
            //this form2 demektir.
            form10.MdiParent = this;
            form10.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            //this form2 demektir.
            form5.MdiParent = this;
            form5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            //this form2 demektir.
            form11.MdiParent = this;
            form11.Show();
        }
    }
}