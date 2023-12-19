namespace bankapplicationc_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            usernametxt = new TextBox();
            label2 = new Label();
            passwordtxt = new TextBox();
            label3 = new Label();
            exitbtn = new Button();
            checkbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(239, 83);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(212, 40);
            usernametxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 90);
            label2.Name = "label2";
            label2.Size = new Size(152, 33);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(239, 158);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(212, 40);
            passwordtxt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(81, 161);
            label3.Name = "label3";
            label3.Size = new Size(147, 33);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(524, 12);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(49, 34);
            exitbtn.TabIndex = 3;
            exitbtn.Text = "X";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // checkbutton
            // 
            checkbutton.BackgroundImage = Properties.Resources.indir__2_;
            checkbutton.BackgroundImageLayout = ImageLayout.Stretch;
            checkbutton.Location = new Point(391, 228);
            checkbutton.Name = "checkbutton";
            checkbutton.Size = new Size(60, 52);
            checkbutton.TabIndex = 4;
            checkbutton.UseVisualStyleBackColor = true;
            checkbutton.Click += checkbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(590, 332);
            Controls.Add(checkbutton);
            Controls.Add(exitbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(label1);
            Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernametxt;
        private Label label2;
        private TextBox passwordtxt;
        private Label label3;
        private Button exitbtn;
        private Button checkbutton;
    }
}
