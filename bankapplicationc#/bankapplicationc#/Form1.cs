using bankapplicationc_.classes;

namespace bankapplicationc_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string[,] users = new string[2, 3];
        private void checkbutton_Click(object sender, EventArgs e)
        {
            bool dogru = false;
            //GetLength 0 olursa satýr 1 olursa sutun
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if ((users[i, 1] == usernametxt.Text) && (users[i, 2] == passwordtxt.Text))
                {
                    this.Hide();
                    Form2 form2 = new Form2(this);
                    //form2 nin içine form1 i gonderdi
                    form2.WindowState = FormWindowState.Maximized;
                    form2.Show();
                    dogru = true;
                    //continue;
                    break;
                }
                if (!dogru)
                {
                    MessageBox.Show("We did not have such a branch officer. Try again ");
                    usernametxt.Text = " ";
                    passwordtxt.Text = "";
                    usernametxt.Select();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernametxt.Select();
            //tanýmlanmýþ kullanicilar dizisinin içini kullanýcý kayýtlarýyla doldurdum.
            //id
            users[0, 0] = "1";
            //kullaniciadi
            users[0, 1] = "Admin";
            //sifre
            users[0, 2] = "333";
            users[1, 0] = "2";
            users[1, 1] = "elif";
            users[1, 2] = "444";
        }
    }
}
