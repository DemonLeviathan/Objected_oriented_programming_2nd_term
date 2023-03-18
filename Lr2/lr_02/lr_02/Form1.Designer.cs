namespace lr_02
{
    partial class Bank
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
            components = new System.ComponentModel.Container();
            Surname = new Label();
            writeSurname = new TextBox();
            writeName = new TextBox();
            lastName = new Label();
            writeLastName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Birthday = new Label();
            PasportNumber = new Label();
            passportNum = new TextBox();
            monthCalendar1 = new MonthCalendar();
            ScoreNumber = new Label();
            enterScoreNum = new TextBox();
            OpenDate = new Label();
            PhoneNumber = new Label();
            writePhoneNum = new MaskedTextBox();
            GetSMS = new Label();
            checkBox1 = new CheckBox();
            ConnectIB = new Label();
            checkBox2 = new CheckBox();
            SaveInfo = new Button();
            richTextBox1 = new RichTextBox();
            Readfrom = new Button();
            OwnersName = new Label();
            errorData = new ErrorProvider(components);
            errorNumber = new ErrorProvider(components);
            comboBox1 = new ComboBox();
            ContributionType = new Label();
            ((System.ComponentModel.ISupportInitialize)errorData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNumber).BeginInit();
            SuspendLayout();
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(12, 9);
            Surname.Name = "Surname";
            Surname.Size = new Size(70, 20);
            Surname.TabIndex = 0;
            Surname.Text = "Surname:";
            Surname.Click += Surname_Click;
            // 
            // writeSurname
            // 
            writeSurname.Location = new Point(12, 32);
            writeSurname.Name = "writeSurname";
            writeSurname.Size = new Size(125, 27);
            writeSurname.TabIndex = 1;
            writeSurname.KeyPress += writeSurname_KeyPress;
            // 
            // writeName
            // 
            writeName.Location = new Point(169, 32);
            writeName.Name = "writeName";
            writeName.Size = new Size(125, 27);
            writeName.TabIndex = 3;
            writeName.KeyPress += writeName_KeyPress;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(329, 9);
            lastName.Name = "lastName";
            lastName.Size = new Size(79, 20);
            lastName.TabIndex = 4;
            lastName.Text = "Last name:";
            // 
            // writeLastName
            // 
            writeLastName.Location = new Point(329, 32);
            writeLastName.Name = "writeLastName";
            writeLastName.Size = new Size(125, 27);
            writeLastName.TabIndex = 5;
            writeLastName.KeyPress += writeLastName_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 105);
            dateTimePicker1.MaxDate = new DateTime(2023, 3, 17, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2023, 3, 17, 0, 0, 0, 0);
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.Location = new Point(12, 82);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(67, 20);
            Birthday.TabIndex = 7;
            Birthday.Text = "Birthday:";
            // 
            // PasportNumber
            // 
            PasportNumber.AutoSize = true;
            PasportNumber.Location = new Point(12, 144);
            PasportNumber.Name = "PasportNumber";
            PasportNumber.Size = new Size(122, 20);
            PasportNumber.TabIndex = 8;
            PasportNumber.Text = "Passport number:";
            PasportNumber.Click += label1_Click;
            // 
            // passportNum
            // 
            passportNum.Location = new Point(12, 167);
            passportNum.Name = "passportNum";
            passportNum.Size = new Size(125, 27);
            passportNum.TabIndex = 9;
            passportNum.KeyPress += passportNum_KeyPress;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 400);
            monthCalendar1.MaxDate = new DateTime(2023, 3, 17, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            // 
            // ScoreNumber
            // 
            ScoreNumber.AutoSize = true;
            ScoreNumber.Location = new Point(13, 299);
            ScoreNumber.Name = "ScoreNumber";
            ScoreNumber.Size = new Size(104, 20);
            ScoreNumber.TabIndex = 13;
            ScoreNumber.Text = "Score number:";
            // 
            // enterScoreNum
            // 
            enterScoreNum.Location = new Point(13, 322);
            enterScoreNum.Name = "enterScoreNum";
            enterScoreNum.Size = new Size(125, 27);
            enterScoreNum.TabIndex = 14;
            enterScoreNum.KeyPress += enterScoreNum_KeyPress;
            // 
            // OpenDate
            // 
            OpenDate.AutoSize = true;
            OpenDate.Location = new Point(13, 371);
            OpenDate.Name = "OpenDate";
            OpenDate.Size = new Size(82, 20);
            OpenDate.TabIndex = 15;
            OpenDate.Text = "Open date:";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(244, 299);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(108, 20);
            PhoneNumber.TabIndex = 16;
            PhoneNumber.Text = "Phone number:";
            // 
            // writePhoneNum
            // 
            writePhoneNum.Location = new Point(244, 322);
            writePhoneNum.Name = "writePhoneNum";
            writePhoneNum.Size = new Size(125, 27);
            writePhoneNum.TabIndex = 17;
            writePhoneNum.KeyPress += writePhoneNum_KeyPress;
            // 
            // GetSMS
            // 
            GetSMS.AutoSize = true;
            GetSMS.Location = new Point(12, 625);
            GetSMS.Name = "GetSMS";
            GetSMS.Size = new Size(68, 20);
            GetSMS.TabIndex = 18;
            GetSMS.Text = "Get SMS:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 648);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 24);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Get";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ConnectIB
            // 
            ConnectIB.AutoSize = true;
            ConnectIB.Location = new Point(12, 684);
            ConnectIB.Name = "ConnectIB";
            ConnectIB.Size = new Size(180, 20);
            ConnectIB.TabIndex = 20;
            ConnectIB.Text = "Connect internet-banking:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(13, 707);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 24);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "Connect";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // SaveInfo
            // 
            SaveInfo.Location = new Point(471, 256);
            SaveInfo.Name = "SaveInfo";
            SaveInfo.Size = new Size(94, 29);
            SaveInfo.TabIndex = 23;
            SaveInfo.Text = "Save";
            SaveInfo.UseVisualStyleBackColor = true;
            SaveInfo.Click += SaveInfo_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(594, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(317, 319);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // Readfrom
            // 
            Readfrom.Location = new Point(471, 322);
            Readfrom.Name = "Readfrom";
            Readfrom.Size = new Size(94, 29);
            Readfrom.TabIndex = 25;
            Readfrom.Text = "Read";
            Readfrom.UseVisualStyleBackColor = true;
            Readfrom.Click += Readfrom_Click;
            // 
            // OwnersName
            // 
            OwnersName.AutoSize = true;
            OwnersName.Location = new Point(169, 9);
            OwnersName.Name = "OwnersName";
            OwnersName.Size = new Size(52, 20);
            OwnersName.TabIndex = 27;
            OwnersName.Text = "Name:";
            // 
            // errorData
            // 
            errorData.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorData.ContainerControl = this;
            // 
            // errorNumber
            // 
            errorNumber.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorNumber.ContainerControl = this;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ContributionType
            // 
            ContributionType.AutoSize = true;
            ContributionType.Location = new Point(13, 208);
            ContributionType.Name = "ContributionType";
            ContributionType.Size = new Size(123, 20);
            ContributionType.TabIndex = 29;
            ContributionType.Text = "ContributionType";
            // 
            // Bank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 760);
            Controls.Add(ContributionType);
            Controls.Add(comboBox1);
            Controls.Add(OwnersName);
            Controls.Add(Readfrom);
            Controls.Add(richTextBox1);
            Controls.Add(SaveInfo);
            Controls.Add(checkBox2);
            Controls.Add(ConnectIB);
            Controls.Add(checkBox1);
            Controls.Add(GetSMS);
            Controls.Add(writePhoneNum);
            Controls.Add(PhoneNumber);
            Controls.Add(OpenDate);
            Controls.Add(enterScoreNum);
            Controls.Add(ScoreNumber);
            Controls.Add(monthCalendar1);
            Controls.Add(passportNum);
            Controls.Add(PasportNumber);
            Controls.Add(Birthday);
            Controls.Add(dateTimePicker1);
            Controls.Add(writeLastName);
            Controls.Add(lastName);
            Controls.Add(writeName);
            Controls.Add(writeSurname);
            Controls.Add(Surname);
            Name = "Bank";
            Text = "Bank";
            Load += Bank_Load;
            ((System.ComponentModel.ISupportInitialize)errorData).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Surname;
        private TextBox writeSurname;
        private TextBox writeName;
        private Label lastName;
        private TextBox writeLastName;
        private DateTimePicker dateTimePicker1;
        private Label Birthday;
        private Label PasportNumber;
        private TextBox passportNum;
        private MonthCalendar monthCalendar1;
        private Label ScoreNumber;
        private TextBox enterScoreNum;
        private Label OpenDate;
        private Label PhoneNumber;
        private MaskedTextBox writePhoneNum;
        private Label GetSMS;
        private CheckBox checkBox1;
        private Label ConnectIB;
        private CheckBox checkBox2;
        private Button SaveInfo;
        private RichTextBox richTextBox1;
        private Button Readfrom;
        private Label OwnersName;
        private ErrorProvider errorData;
        private ErrorProvider errorNumber;
        private Label ContributionType;
        private ComboBox comboBox1;
    }
}