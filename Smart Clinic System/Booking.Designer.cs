namespace Smart_Clinic_System
{
    partial class Booking
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
            dgvVisits = new DataGridView();
            colDoctor = new DataGridViewTextBoxColumn();
            colSpecialty = new DataGridViewTextBoxColumn();
            txtPhone = new TextBox();
            pnlPatientInfo = new Panel();
            lblPatientTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblNationalID = new Label();
            txtNationalID = new TextBox();
            lblDOB = new Label();
            txtDOB = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            txtGender = new TextBox();
            lblGovernorate = new Label();
            txtGovernorate = new TextBox();
            lblPhone = new Label();
            grpVisits = new GroupBox();
            btnRefresh = new Button();
            btnBack = new Button();
            grpAddPatient = new GroupBox();
            label2 = new Label();
            Specialization = new TextBox();
            label1 = new Label();
            DoctorName = new TextBox();
            label6 = new Label();
            ClinicNumber = new TextBox();
            lblNextVisit = new Label();
            dtpNextVisit = new DateTimePicker();
            label3 = new Label();
            DoctorPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVisits).BeginInit();
            pnlPatientInfo.SuspendLayout();
            grpVisits.SuspendLayout();
            grpAddPatient.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(857, 53);
            button1.Name = "button1";
            button1.Size = new Size(93, 39);
            button1.TabIndex = 15;
            button1.Text = "حجز موعد";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvVisits
            // 
            dgvVisits.AllowUserToAddRows = false;
            dgvVisits.AllowUserToDeleteRows = false;
            dgvVisits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisits.Columns.AddRange(new DataGridViewColumn[] { colDoctor, colSpecialty });
            dgvVisits.Location = new Point(11, 28);
            dgvVisits.MultiSelect = false;
            dgvVisits.Name = "dgvVisits";
            dgvVisits.ReadOnly = true;
            dgvVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisits.Size = new Size(576, 380);
            dgvVisits.TabIndex = 0;
            dgvVisits.CellContentClick += dgvVisits_CellContentClick;
            // 
            // colDoctor
            // 
            colDoctor.FillWeight = 30F;
            colDoctor.HeaderText = "الدكتور";
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            // 
            // colSpecialty
            // 
            colSpecialty.FillWeight = 25F;
            colSpecialty.HeaderText = "التخصص";
            colSpecialty.Name = "colSpecialty";
            colSpecialty.ReadOnly = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(705, 83);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(120, 23);
            txtPhone.TabIndex = 14;
            // 
            // pnlPatientInfo
            // 
            pnlPatientInfo.Controls.Add(button1);
            pnlPatientInfo.Controls.Add(lblPatientTitle);
            pnlPatientInfo.Controls.Add(lblName);
            pnlPatientInfo.Controls.Add(txtName);
            pnlPatientInfo.Controls.Add(lblNationalID);
            pnlPatientInfo.Controls.Add(txtNationalID);
            pnlPatientInfo.Controls.Add(lblDOB);
            pnlPatientInfo.Controls.Add(txtDOB);
            pnlPatientInfo.Controls.Add(lblAge);
            pnlPatientInfo.Controls.Add(txtAge);
            pnlPatientInfo.Controls.Add(lblGender);
            pnlPatientInfo.Controls.Add(txtGender);
            pnlPatientInfo.Controls.Add(lblGovernorate);
            pnlPatientInfo.Controls.Add(txtGovernorate);
            pnlPatientInfo.Controls.Add(lblPhone);
            pnlPatientInfo.Controls.Add(txtPhone);
            pnlPatientInfo.Location = new Point(0, 1);
            pnlPatientInfo.Name = "pnlPatientInfo";
            pnlPatientInfo.Size = new Size(960, 120);
            pnlPatientInfo.TabIndex = 5;
            // 
            // lblPatientTitle
            // 
            lblPatientTitle.AutoSize = true;
            lblPatientTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPatientTitle.Location = new Point(15, 16);
            lblPatientTitle.Name = "lblPatientTitle";
            lblPatientTitle.Size = new Size(225, 25);
            lblPatientTitle.TabIndex = 0;
            lblPatientTitle.Text = "معلومات المريض الأساسية";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(34, 15);
            lblName.TabIndex = 1;
            lblName.Text = "الاسم";
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 23);
            txtName.TabIndex = 2;
            // 
            // lblNationalID
            // 
            lblNationalID.AutoSize = true;
            lblNationalID.Location = new Point(345, 53);
            lblNationalID.Name = "lblNationalID";
            lblNationalID.Size = new Size(70, 15);
            lblNationalID.TabIndex = 3;
            lblNationalID.Text = "الرقم القومي";
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(425, 50);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.ReadOnly = true;
            txtNationalID.Size = new Size(180, 23);
            txtNationalID.TabIndex = 4;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(625, 53);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(65, 15);
            lblDOB.TabIndex = 5;
            lblDOB.Text = "تاريخ الميلاد";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(705, 50);
            txtDOB.Name = "txtDOB";
            txtDOB.ReadOnly = true;
            txtDOB.Size = new Size(120, 23);
            txtDOB.TabIndex = 6;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(19, 86);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(32, 15);
            lblAge.TabIndex = 7;
            lblAge.Text = "السن";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(95, 83);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(80, 23);
            txtAge.TabIndex = 8;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(195, 86);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(39, 15);
            lblGender.TabIndex = 9;
            lblGender.Text = "الجنس";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(245, 83);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(70, 23);
            txtGender.TabIndex = 10;
            // 
            // lblGovernorate
            // 
            lblGovernorate.AutoSize = true;
            lblGovernorate.Location = new Point(345, 86);
            lblGovernorate.Name = "lblGovernorate";
            lblGovernorate.Size = new Size(53, 15);
            lblGovernorate.TabIndex = 11;
            lblGovernorate.Text = "المحافظة";
            // 
            // txtGovernorate
            // 
            txtGovernorate.Location = new Point(425, 83);
            txtGovernorate.Name = "txtGovernorate";
            txtGovernorate.ReadOnly = true;
            txtGovernorate.Size = new Size(180, 23);
            txtGovernorate.TabIndex = 12;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(625, 86);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(46, 15);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "التليفون";
            // 
            // grpVisits
            // 
            grpVisits.Controls.Add(dgvVisits);
            grpVisits.Font = new Font("Segoe UI", 10F);
            grpVisits.Location = new Point(5, 131);
            grpVisits.Name = "grpVisits";
            grpVisits.Size = new Size(600, 420);
            grpVisits.TabIndex = 6;
            grpVisits.TabStop = false;
            grpVisits.Text = "سجل الزيارات";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(763, 566);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 38);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "تحديث البيانات";
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(643, 566);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 38);
            btnBack.TabIndex = 9;
            btnBack.Text = "العودة";
            // 
            // grpAddPatient
            // 
            grpAddPatient.Controls.Add(label3);
            grpAddPatient.Controls.Add(DoctorPhone);
            grpAddPatient.Controls.Add(label2);
            grpAddPatient.Controls.Add(Specialization);
            grpAddPatient.Controls.Add(label1);
            grpAddPatient.Controls.Add(DoctorName);
            grpAddPatient.Controls.Add(label6);
            grpAddPatient.Controls.Add(ClinicNumber);
            grpAddPatient.Controls.Add(lblNextVisit);
            grpAddPatient.Controls.Add(dtpNextVisit);
            grpAddPatient.Font = new Font("Segoe UI", 10F);
            grpAddPatient.Location = new Point(625, 131);
            grpAddPatient.Name = "grpAddPatient";
            grpAddPatient.Size = new Size(335, 420);
            grpAddPatient.TabIndex = 10;
            grpAddPatient.TabStop = false;
            grpAddPatient.Text = "إضافة مريض / تسجيل زيارة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 122);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 22;
            label2.Text = "التخصص";
            // 
            // Specialization
            // 
            Specialization.Location = new Point(29, 155);
            Specialization.Name = "Specialization";
            Specialization.ReadOnly = true;
            Specialization.Size = new Size(280, 25);
            Specialization.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 43);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 0;
            label1.Text = "اسم الدكتور";
            // 
            // DoctorName
            // 
            DoctorName.Location = new Point(29, 71);
            DoctorName.Name = "DoctorName";
            DoctorName.ReadOnly = true;
            DoctorName.Size = new Size(280, 25);
            DoctorName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 204);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 12;
            label6.Text = "رقم العياده";
            label6.Click += label6_Click;
            // 
            // ClinicNumber
            // 
            ClinicNumber.Location = new Point(29, 237);
            ClinicNumber.Name = "ClinicNumber";
            ClinicNumber.ReadOnly = true;
            ClinicNumber.Size = new Size(280, 25);
            ClinicNumber.TabIndex = 13;
            // 
            // lblNextVisit
            // 
            lblNextVisit.AutoSize = true;
            lblNextVisit.Location = new Point(21, 380);
            lblNextVisit.Name = "lblNextVisit";
            lblNextVisit.Size = new Size(74, 19);
            lblNextVisit.TabIndex = 20;
            lblNextVisit.Text = "موعد الحجز";
            // 
            // dtpNextVisit
            // 
            dtpNextVisit.Format = DateTimePickerFormat.Short;
            dtpNextVisit.Location = new Point(110, 377);
            dtpNextVisit.Name = "dtpNextVisit";
            dtpNextVisit.ShowCheckBox = true;
            dtpNextVisit.Size = new Size(180, 25);
            dtpNextVisit.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 286);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 24;
            label3.Text = "رقم الهاتف";
            // 
            // DoctorPhone
            // 
            DoctorPhone.Location = new Point(29, 319);
            DoctorPhone.Name = "DoctorPhone";
            DoctorPhone.ReadOnly = true;
            DoctorPhone.Size = new Size(280, 25);
            DoctorPhone.TabIndex = 25;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 610);
            Controls.Add(grpAddPatient);
            Controls.Add(pnlPatientInfo);
            Controls.Add(grpVisits);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Name = "Booking";
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)dgvVisits).EndInit();
            pnlPatientInfo.ResumeLayout(false);
            pnlPatientInfo.PerformLayout();
            grpVisits.ResumeLayout(false);
            grpAddPatient.ResumeLayout(false);
            grpAddPatient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvVisits;
        private TextBox txtPhone;
        private Panel pnlPatientInfo;
        private Label lblPatientTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblNationalID;
        private TextBox txtNationalID;
        private Label lblDOB;
        private TextBox txtDOB;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private TextBox txtGender;
        private Label lblGovernorate;
        private TextBox txtGovernorate;
        private Label lblPhone;
        private GroupBox grpVisits;
        private Button btnRefresh;
        private Button btnBack;
        private DataGridViewTextBoxColumn colDoctor;
        private DataGridViewTextBoxColumn colSpecialty;
        private GroupBox grpAddPatient;
        private Label label1;
        private TextBox DoctorName;
        private Label label6;
        private TextBox ClinicNumber;
        private Label lblNextVisit;
        private Label label2;
        private TextBox Specialization;
        private DateTimePicker dtpNextVisit;
        private Label label3;
        private TextBox DoctorPhone;
    }
}