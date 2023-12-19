namespace bankapplicationc_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(0, -2);
            button1.Name = "button1";
            button1.Size = new Size(364, 51);
            button1.TabIndex = 0;
            button1.Text = "Create New Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 98);
            button2.Name = "button2";
            button2.Size = new Size(364, 59);
            button2.TabIndex = 2;
            button2.Text = "Search Accounts";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 44);
            button4.Name = "button4";
            button4.Size = new Size(364, 59);
            button4.TabIndex = 6;
            button4.Text = "Update Existing Account";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(0, 152);
            button5.Name = "button5";
            button5.Size = new Size(364, 54);
            button5.TabIndex = 8;
            button5.Text = "Deposit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(0, 199);
            button6.Name = "button6";
            button6.Size = new Size(364, 55);
            button6.TabIndex = 10;
            button6.Text = "Withdrawal";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 251);
            button3.Name = "button3";
            button3.Size = new Size(364, 60);
            button3.TabIndex = 12;
            button3.Text = "Pay the bill";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(0, 308);
            button7.Name = "button7";
            button7.Size = new Size(364, 61);
            button7.TabIndex = 14;
            button7.Text = "Money Transfer Between Accounts";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(0, 366);
            button8.Name = "button8";
            button8.Size = new Size(364, 61);
            button8.TabIndex = 16;
            button8.Text = "Money Transfers";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(0, 422);
            button9.Name = "button9";
            button9.Size = new Size(364, 59);
            button9.TabIndex = 18;
            button9.Text = "All Account Transactions";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.bank;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(929, 510);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            IsMdiContainer = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank Management System";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}