namespace bankapplicationc_
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            customernametxt = new TextBox();
            accountnumbertxt = new TextBox();
            accounttypecmbbx = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            nationalitycmbbx = new ComboBox();
            emailadrestxt = new TextBox();
            phonenumbertxt = new TextBox();
            ssntxt = new TextBox();
            occupationtxt = new TextBox();
            button1 = new Button();
            label11 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(175, 22);
            label1.TabIndex = 0;
            label1.Text = "Customer Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 91);
            label2.Name = "label2";
            label2.Size = new Size(182, 22);
            label2.TabIndex = 0;
            label2.Text = "Account Number : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 167);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 0;
            label3.Text = "Account Type : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 235);
            label4.Name = "label4";
            label4.Size = new Size(101, 22);
            label4.TabIndex = 0;
            label4.Text = "Gender  : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 306);
            label5.Name = "label5";
            label5.Size = new Size(147, 22);
            label5.TabIndex = 0;
            label5.Text = "Date of Birth  : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 364);
            label6.Name = "label6";
            label6.Size = new Size(129, 22);
            label6.TabIndex = 0;
            label6.Text = "Nationality  : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 421);
            label7.Name = "label7";
            label7.Size = new Size(158, 22);
            label7.TabIndex = 0;
            label7.Text = "E mail Adress  : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 485);
            label8.Name = "label8";
            label8.Size = new Size(170, 22);
            label8.TabIndex = 0;
            label8.Text = "Phone Number  : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(159, 541);
            label9.Name = "label9";
            label9.Size = new Size(71, 22);
            label9.TabIndex = 0;
            label9.Text = "SSN  : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(91, 594);
            label10.Name = "label10";
            label10.Size = new Size(139, 22);
            label10.TabIndex = 0;
            label10.Text = "Occupation  : ";
            // 
            // customernametxt
            // 
            customernametxt.Location = new Point(288, 20);
            customernametxt.Name = "customernametxt";
            customernametxt.Size = new Size(311, 29);
            customernametxt.TabIndex = 1;
            customernametxt.Leave += customernametxt_Leave_1;
            // 
            // accountnumbertxt
            // 
            accountnumbertxt.Location = new Point(288, 84);
            accountnumbertxt.Name = "accountnumbertxt";
            accountnumbertxt.Size = new Size(311, 29);
            accountnumbertxt.TabIndex = 1;
            // 
            // accounttypecmbbx
            // 
            accounttypecmbbx.DropDownStyle = ComboBoxStyle.DropDownList;
            accounttypecmbbx.FormattingEnabled = true;
            accounttypecmbbx.Items.AddRange(new object[] { "Standard Current Account", "Savings Account", "Salary Account", "Fixed Deposit Account", "Recurring Deposit Account", "NRI Account" });
            accounttypecmbbx.Location = new Point(288, 159);
            accounttypecmbbx.Name = "accounttypecmbbx";
            accounttypecmbbx.Size = new Size(311, 30);
            accounttypecmbbx.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(300, 233);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 26);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(422, 233);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 26);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(567, 235);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 26);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(299, 300);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 29);
            dateTimePicker1.TabIndex = 6;
            // 
            // nationalitycmbbx
            // 
            nationalitycmbbx.DropDownStyle = ComboBoxStyle.DropDownList;
            nationalitycmbbx.FormattingEnabled = true;
            nationalitycmbbx.Items.AddRange(new object[] { "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Anguillan", "Citizen of Antigua and Barbuda", "Argentine", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian\t", "Bahraini\t", "Bangladeshi\t", "Barbadian", "Belarusian\t", "Belgian\t", "Belizean\t", "Beninese", "Bermudian", "Bhutanese\t", "Bolivian\t", "Citizen of Bosnia and Herzegovina", "Botswanan\t", "Brazilian\t", "British\t", "British Virgin Islander", "Bruneian\t", "Bulgarian\t", "Burkinan\t", "Burmese", "Burundian\t ", "Cambodian", "Cameroonian", "Canadian\t", "Cape Verdean", "Cayman Islander\t", "Central African\t", "Chadian\t", "Chilean", "Chinese\t", "Colombian\t", "Comoran\tCongolese (Congo)", "Congolese (DRC)\t", "Cook Islander\t", "Costa Rican\t", "Croatian", "Cuban\t", "Cymraes\t", "Cymro\t", "Cypriot", "Czech", "Danish\t", "Djiboutian\t", "Dominican\t", "Citizen of the Dominican Republic", "Dutch", "East Timorese\t", "Ecuadorean\t", "Egyptian\t", "Emirati", "English\t", "Equatorial Guinean\t", "Eritrean\t", "Estonian", "Ethiopian", "Faroese\t", "Fijian\t", "Filipino\t", "Finnish", "French", "Gabonese", "Gambian\t", "Georgian\t", "German", "Ghanaian\t", "Gibraltarian\t", "Greek\t", "Greenlandic", "Grenadian\t", "Guamanian\t", "Guatemalan\t", "Citizen of Guinea-Bissau", "Guinean\t", "Guyanese", "Haitian\t", "Honduran\t", "Hong Konger\t", "Hungarian", "Icelandic\t", "Indian\t", "Indonesian\t", "Iranian", "Iraqi\t", "Irish\t", "Israeli\t", "Italian", "Ivorian", "Jamaican\t", "Japanese\t", "Jordanian", "Kazakh\t", "Kenyan\t", "Kittitian\t", "Citizen of Kiribati", "Kosovan\t", "Kuwaiti\t", "Kyrgyz", "Lao\t", "Latvian\t", "Lebanese\t", "Liberian", "Libyan", "Liechtenstein citizen\t", "Lithuanian\t", "Luxembourger", "Macanese", "Macedonian\t", "Malagasy\t", "Malawian", "Malaysian\t", "Maldivian\t", "Malian\t", "Maltese", "Marshallese\t", "Martiniquais\t", "Mauritanian\t", "Mauritian", "Mexican\t", "Micronesian\t", "Moldovan\t", "Monegasque", "Mongolian\t", "Montenegrin\t", "Montserratian\t", "Moroccan", "Mosotho\t", "Mozambican", "Namibian\t", "Nauruan\t", "Nepalese\t", "New Zealander", "Nicaraguan\t", "Nigerian\t", "Nigerien\t", "Niuean", "North Korean\t", "Northern Irish\t", "Norwegian", "Omani", "Pakistani\t", "Palauan\t", "Palestinian\t", "Panamanian", "Papua New Guinean", "Paraguayan\t", "Peruvian\t", "Pitcairn Islander", "Polish\t", "Portuguese\t", "Prydeinig\t", "Puerto Rican", "Qatari", "Romanian", "Russian\t", "Rwandan", "Salvadorean\t", "Sammarinese\t", "Samoan\t", "Sao Tomean", "Saudi Arabian\t", "Scottish\t", "Senegalese\t", "Serbian", "Citizen of Seychelles", "Sierra Leonean\t", "Singaporean\t", "Slovak", "Slovenian\t", "Solomon Islander\t", "Somali\t", "South African", "South Korean\t", "South Sudanese\t", "Spanish\t", "Sri Lankan", "St Helenian\t", "St Lucian\t", "Stateless\t", "Sudanese", "Surinamese\t", "Swazi\t", "Swedish\t", "Swiss", "Syrian", "Taiwanese\t", "Tajik\t", "Tanzanian\t", "Thai", "Togolese\t", "Tongan\t", "Trinidadian\t", "Tristanian", "Tunisian\t", "Turkish\t", "Turkmen\t", "Turks and Caicos Islander", "Tuvaluan", "Ugandan\t", "Ukrainian\t", "Uruguayan\t", "Uzbek", "Vatican citizen\t", "Citizen of Vanuatu\t", "Venezuelan\t", "Vietnamese", "Vincentian", "Wallisian\t", "Welsh", "Yemeni", "Zambian\t", "Zimbabwean" });
            nationalitycmbbx.Location = new Point(299, 361);
            nationalitycmbbx.Name = "nationalitycmbbx";
            nationalitycmbbx.Size = new Size(300, 30);
            nationalitycmbbx.TabIndex = 7;
            // 
            // emailadrestxt
            // 
            emailadrestxt.Location = new Point(300, 421);
            emailadrestxt.Name = "emailadrestxt";
            emailadrestxt.Size = new Size(299, 29);
            emailadrestxt.TabIndex = 8;
            emailadrestxt.Leave += emailadrestxt_Leave;
            // 
            // phonenumbertxt
            // 
            phonenumbertxt.Location = new Point(300, 485);
            phonenumbertxt.Name = "phonenumbertxt";
            phonenumbertxt.Size = new Size(299, 29);
            phonenumbertxt.TabIndex = 9;
            phonenumbertxt.Leave += phonenumbertxt_Leave;
            // 
            // ssntxt
            // 
            ssntxt.Location = new Point(300, 541);
            ssntxt.Name = "ssntxt";
            ssntxt.Size = new Size(299, 29);
            ssntxt.TabIndex = 10;
            ssntxt.Leave += ssntxt_Leave;
            // 
            // occupationtxt
            // 
            occupationtxt.Location = new Point(300, 596);
            occupationtxt.Name = "occupationtxt";
            occupationtxt.Size = new Size(299, 29);
            occupationtxt.TabIndex = 11;
            occupationtxt.TextChanged += occupationtxt_TextChanged;
            occupationtxt.Leave += occupationtxt_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(336, 666);
            button1.Name = "button1";
            button1.Size = new Size(263, 60);
            button1.TabIndex = 12;
            button1.Text = "Create New  Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(767, 34);
            label11.Name = "label11";
            label11.Size = new Size(110, 18);
            label11.TabIndex = 13;
            label11.Text = "Profile Picture";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(831, 196);
            button2.Name = "button2";
            button2.Size = new Size(91, 34);
            button2.TabIndex = 15;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(772, 666);
            button3.Name = "button3";
            button3.Size = new Size(125, 60);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.profile_icon_design_free_vector;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.profile_icon_design_free_vector;
            pictureBox1.Location = new Point(772, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 114);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(299, 52);
            label12.Name = "label12";
            label12.Size = new Size(97, 14);
            label12.TabIndex = 0;
            label12.Text = "CustomerName ";
            label12.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(300, 639);
            label13.Name = "label13";
            label13.Size = new Size(68, 14);
            label13.TabIndex = 18;
            label13.Text = "Occupation";
            label13.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(300, 517);
            label14.Name = "label14";
            label14.Size = new Size(86, 14);
            label14.TabIndex = 19;
            label14.Text = "PhoneNumber";
            label14.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(299, 573);
            label15.Name = "label15";
            label15.Size = new Size(28, 14);
            label15.TabIndex = 20;
            label15.Text = "SSN";
            label15.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(300, 453);
            label16.Name = "label16";
            label16.Size = new Size(36, 14);
            label16.TabIndex = 21;
            label16.Text = "Email";
            label16.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(967, 738);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(occupationtxt);
            Controls.Add(ssntxt);
            Controls.Add(phonenumbertxt);
            Controls.Add(emailadrestxt);
            Controls.Add(nationalitycmbbx);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(accounttypecmbbx);
            Controls.Add(accountnumbertxt);
            Controls.Add(customernametxt);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(label1);
            Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Account";
            Load += Form3_Load;
            Leave += Form3_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox customernametxt;
        private TextBox accountnumbertxt;
        private ComboBox accounttypecmbbx;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private DateTimePicker dateTimePicker1;
        private ComboBox nationalitycmbbx;
        private TextBox emailadrestxt;
        private TextBox phonenumbertxt;
        private TextBox ssntxt;
        private TextBox occupationtxt;
        private Button button1;
        private Label label11;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}