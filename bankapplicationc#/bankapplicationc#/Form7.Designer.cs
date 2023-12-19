namespace bankapplicationc_
{
    partial class Form7
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 0;
            label1.Text = "Deposit";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Agency FB", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(810, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Account";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(271, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 43);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.TryAgain;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(393, 91);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 40);
            label2.Name = "label2";
            label2.Size = new Size(220, 29);
            label2.TabIndex = 0;
            label2.Text = "Account Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 317);
            label5.Name = "label5";
            label5.Size = new Size(258, 33);
            label5.TabIndex = 2;
            label5.Text = "Customer Name : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 377);
            label6.Name = "label6";
            label6.Size = new Size(225, 33);
            label6.TabIndex = 2;
            label6.Text = "Account Type : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 428);
            label7.Name = "label7";
            label7.Size = new Size(250, 33);
            label7.TabIndex = 2;
            label7.Text = "Current Balance :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 482);
            label8.Name = "label8";
            label8.Size = new Size(247, 33);
            label8.TabIndex = 2;
            label8.Text = "Deposit Amount :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(357, 310);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(362, 40);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(357, 370);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(362, 40);
            textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(357, 428);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(362, 40);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(357, 482);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(362, 40);
            textBox7.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(576, 555);
            button2.Name = "button2";
            button2.Size = new Size(143, 54);
            button2.TabIndex = 4;
            button2.Text = "Add Deposit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1360, 631);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Form7_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Button button2;
    }
}