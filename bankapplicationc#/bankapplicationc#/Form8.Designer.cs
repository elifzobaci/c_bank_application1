namespace bankapplicationc_
{
    partial class Form8
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 0;
            label1.Text = "Withdrawal";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(409, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Account";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(259, 83);
            button1.Name = "button1";
            button1.Size = new Size(148, 44);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Agency FB", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 34);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 37);
            label2.Name = "label2";
            label2.Size = new Size(184, 26);
            label2.TabIndex = 0;
            label2.Text = "Account Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 267);
            label3.Name = "label3";
            label3.Size = new Size(258, 33);
            label3.TabIndex = 2;
            label3.Text = "Customer Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(103, 336);
            label4.Name = "label4";
            label4.Size = new Size(225, 33);
            label4.TabIndex = 2;
            label4.Text = "Account Type : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(70, 407);
            label5.Name = "label5";
            label5.Size = new Size(258, 33);
            label5.TabIndex = 2;
            label5.Text = "Current Balance : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 467);
            label6.Name = "label6";
            label6.Size = new Size(305, 33);
            label6.TabIndex = 2;
            label6.Text = "Withdrawal Amount : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 40);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(334, 333);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 40);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(334, 400);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(374, 40);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(334, 467);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(374, 40);
            textBox4.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(508, 539);
            button2.Name = "button2";
            button2.Size = new Size(200, 52);
            button2.TabIndex = 7;
            button2.Text = "Withdrawal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(852, 628);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdrawal";
            Load += Form8_Load;
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
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
    }
}