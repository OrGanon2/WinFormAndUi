
namespace WinFormAndUi
{
    partial class StudentManagment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDtext = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseManagment = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOFbirthPicker = new System.Windows.Forms.DateTimePicker();
            this.CityCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentPaidBox = new System.Windows.Forms.TextBox();
            this.PaymentCostBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(47, 48);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(180, 27);
            this.IDtext.TabIndex = 0;
            this.IDtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(109, 147);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(125, 27);
            this.LastNameBox.TabIndex = 1;
            this.LastNameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.Location = new System.Drawing.Point(102, 81);
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(125, 27);
            this.firstnametextbox.TabIndex = 2;
            this.firstnametextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(102, 114);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(125, 27);
            this.PhoneNumberBox.TabIndex = 3;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(59, 177);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(125, 27);
            this.EmailBox.TabIndex = 4;
            // 
            // IDTextBox
            // 
            this.IDTextBox.AutoSize = true;
            this.IDTextBox.Location = new System.Drawing.Point(17, 48);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(24, 20);
            this.IDTextBox.TabIndex = 5;
            this.IDTextBox.Text = "ID";
            this.IDTextBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(16, 84);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(80, 20);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(17, 117);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(79, 20);
            this.LastName.TabIndex = 7;
            this.LastName.Text = "Last Name";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(0, 150);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.Click += new System.EventHandler(this.PhoneNumber_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(7, 180);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date Of Birth";
            // 
            // CourseManagment
            // 
            this.CourseManagment.FormattingEnabled = true;
            this.CourseManagment.Location = new System.Drawing.Point(452, 48);
            this.CourseManagment.Name = "CourseManagment";
            this.CourseManagment.Size = new System.Drawing.Size(178, 268);
            this.CourseManagment.TabIndex = 12;
            this.CourseManagment.SelectedIndexChanged += new System.EventHandler(this.CourseManagment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Course Managment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateOFbirthPicker
            // 
            this.DateOFbirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOFbirthPicker.Location = new System.Drawing.Point(102, 211);
            this.DateOFbirthPicker.Name = "DateOFbirthPicker";
            this.DateOFbirthPicker.Size = new System.Drawing.Size(108, 27);
            this.DateOFbirthPicker.TabIndex = 10;
            // 
            // CityCombo
            // 
            this.CityCombo.FormattingEnabled = true;
            this.CityCombo.Items.AddRange(new object[] {
            "Rishon Lezzion",
            "Yavne",
            "Gan Yavne",
            "Jerusalem",
            "Tel Aviv",
            "Holon",
            "Bat yam",
            "Ramat Gan"});
            this.CityCombo.Location = new System.Drawing.Point(59, 244);
            this.CityCombo.Name = "CityCombo";
            this.CityCombo.Size = new System.Drawing.Size(151, 28);
            this.CityCombo.TabIndex = 14;
            this.CityCombo.SelectedIndexChanged += new System.EventHandler(this.CityCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "City";
            // 
            // PaymentPaidBox
            // 
            this.PaymentPaidBox.Location = new System.Drawing.Point(114, 315);
            this.PaymentPaidBox.Name = "PaymentPaidBox";
            this.PaymentPaidBox.Size = new System.Drawing.Size(125, 27);
            this.PaymentPaidBox.TabIndex = 16;
            // 
            // PaymentCostBox
            // 
            this.PaymentCostBox.Location = new System.Drawing.Point(114, 278);
            this.PaymentCostBox.Name = "PaymentCostBox";
            this.PaymentCostBox.Size = new System.Drawing.Size(125, 27);
            this.PaymentCostBox.TabIndex = 17;
            this.PaymentCostBox.TextChanged += new System.EventHandler(this.PaymentCostBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Payment Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Payment Paid";
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(452, 322);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(181, 67);
            this.AddStudent.TabIndex = 20;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // StudentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PaymentCostBox);
            this.Controls.Add(this.PaymentPaidBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CityCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourseManagment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateOFbirthPicker);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.firstnametextbox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.IDtext);
            this.Name = "StudentManagment";
            this.Size = new System.Drawing.Size(754, 509);
            this.Load += new System.EventHandler(this.StudentManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox firstnametextbox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label IDTextBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox CourseManagment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateOFbirthPicker;
        private System.Windows.Forms.ComboBox CityCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PaymentPaidBox;
        private System.Windows.Forms.TextBox PaymentCostBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddStudent;
    }
}
