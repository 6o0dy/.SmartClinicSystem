namespace Smart_Clinic_System
{
    partial class PatientDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnClose = new Button();
            grpPatientInfo = new GroupBox();
            lblNameLabel = new Label();
            lblNameValue = new Label();
            lblNationalIDLabel = new Label();
            lblIDValue = new Label();
            grpVisitsList = new GroupBox();
            dgvVisitsList = new DataGridView();
            grpVisitDetails = new GroupBox();
            lblDiagnosis = new Label();
            txtDiagnosis = new TextBox();
            lblTreatment = new Label();
            txtTreatment = new TextBox();
            lblReports = new Label();
            txtReports = new TextBox();
            grpPatientInfo.SuspendLayout();
            grpVisitsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisitsList).BeginInit();
            grpVisitDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(10, 90, 180);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Visits";
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(880, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 38);
            btnClose.TabIndex = 1;
            btnClose.Text = "Back";
            btnClose.Click += btnClose_Click;
            // 
            // grpPatientInfo
            // 
            grpPatientInfo.Controls.Add(lblNameLabel);
            grpPatientInfo.Controls.Add(lblNameValue);
            grpPatientInfo.Controls.Add(lblNationalIDLabel);
            grpPatientInfo.Controls.Add(lblIDValue);
            grpPatientInfo.Font = new Font("Segoe UI", 10F);
            grpPatientInfo.Location = new Point(20, 60);
            grpPatientInfo.Name = "grpPatientInfo";
            grpPatientInfo.Size = new Size(960, 80);
            grpPatientInfo.TabIndex = 2;
            grpPatientInfo.TabStop = false;
            grpPatientInfo.Text = "Patient Information";
            // 
            // lblNameLabel
            // 
            lblNameLabel.AutoSize = true;
            lblNameLabel.Location = new Point(20, 35);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(48, 19);
            lblNameLabel.TabIndex = 0;
            lblNameLabel.Text = "Name:";
            // 
            // lblNameValue
            // 
            lblNameValue.ForeColor = Color.Blue;
            lblNameValue.Location = new Point(80, 35);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(100, 23);
            lblNameValue.TabIndex = 1;
            lblNameValue.Text = "[Patient Name]";
            // 
            // lblNationalIDLabel
            // 
            lblNationalIDLabel.AutoSize = true;
            lblNationalIDLabel.Location = new Point(450, 35);
            lblNationalIDLabel.Name = "lblNationalIDLabel";
            lblNationalIDLabel.Size = new Size(81, 19);
            lblNationalIDLabel.TabIndex = 2;
            lblNationalIDLabel.Text = "National ID:";
            // 
            // lblIDValue
            // 
            lblIDValue.Location = new Point(550, 35);
            lblIDValue.Name = "lblIDValue";
            lblIDValue.Size = new Size(100, 23);
            lblIDValue.TabIndex = 3;
            lblIDValue.Text = "[00000000000000]";
            // 
            // grpVisitsList
            // 
            grpVisitsList.Controls.Add(dgvVisitsList);
            grpVisitsList.Font = new Font("Segoe UI", 10F);
            grpVisitsList.Location = new Point(20, 150);
            grpVisitsList.Name = "grpVisitsList";
            grpVisitsList.Size = new Size(300, 480);
            grpVisitsList.TabIndex = 3;
            grpVisitsList.TabStop = false;
            grpVisitsList.Text = "Visit History (Select)";
            // 
            // dgvVisitsList
            // 
            dgvVisitsList.AllowUserToAddRows = false;
            dgvVisitsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVisitsList.BackgroundColor = Color.WhiteSmoke;
            dgvVisitsList.Location = new Point(15, 30);
            dgvVisitsList.Name = "dgvVisitsList";
            dgvVisitsList.ReadOnly = true;
            dgvVisitsList.RowHeadersVisible = false;
            dgvVisitsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisitsList.Size = new Size(270, 430);
            dgvVisitsList.TabIndex = 0;
            dgvVisitsList.SelectionChanged += dgvVisitsList_SelectionChanged;
            // 
            // grpVisitDetails
            // 
            grpVisitDetails.Controls.Add(lblDiagnosis);
            grpVisitDetails.Controls.Add(txtDiagnosis);
            grpVisitDetails.Controls.Add(lblTreatment);
            grpVisitDetails.Controls.Add(txtTreatment);
            grpVisitDetails.Controls.Add(lblReports);
            grpVisitDetails.Controls.Add(txtReports);
            grpVisitDetails.Font = new Font("Segoe UI", 10F);
            grpVisitDetails.Location = new Point(340, 150);
            grpVisitDetails.Name = "grpVisitDetails";
            grpVisitDetails.Size = new Size(640, 480);
            grpVisitDetails.TabIndex = 4;
            grpVisitDetails.TabStop = false;
            grpVisitDetails.Text = "Visit Details";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Location = new Point(25, 40);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(68, 19);
            lblDiagnosis.TabIndex = 0;
            lblDiagnosis.Text = "Diagnosis";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(25, 65);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ReadOnly = true;
            txtDiagnosis.Size = new Size(590, 60);
            txtDiagnosis.TabIndex = 1;
            // 
            // lblTreatment
            // 
            lblTreatment.AutoSize = true;
            lblTreatment.Location = new Point(25, 140);
            lblTreatment.Name = "lblTreatment";
            lblTreatment.Size = new Size(71, 19);
            lblTreatment.TabIndex = 2;
            lblTreatment.Text = "Treatment";
            // 
            // txtTreatment
            // 
            txtTreatment.Location = new Point(25, 165);
            txtTreatment.Multiline = true;
            txtTreatment.Name = "txtTreatment";
            txtTreatment.ReadOnly = true;
            txtTreatment.Size = new Size(590, 100);
            txtTreatment.TabIndex = 3;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Location = new Point(25, 280);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(105, 19);
            lblReports.TabIndex = 4;
            lblReports.Text = "Reports / Notes";
            // 
            // txtReports
            // 
            txtReports.Location = new Point(25, 305);
            txtReports.Multiline = true;
            txtReports.Name = "txtReports";
            txtReports.ReadOnly = true;
            txtReports.Size = new Size(590, 140);
            txtReports.TabIndex = 5;
            // 
            // PatientDetails
            // 
            ClientSize = new Size(1000, 650);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(grpPatientInfo);
            Controls.Add(grpVisitsList);
            Controls.Add(grpVisitDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PatientDetails";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patient File";
            grpPatientInfo.ResumeLayout(false);
            grpPatientInfo.PerformLayout();
            grpVisitsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisitsList).EndInit();
            grpVisitDetails.ResumeLayout(false);
            grpVisitDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpPatientInfo;
        private System.Windows.Forms.Label lblNameLabel;
        public System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblNationalIDLabel;
        public System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.GroupBox grpVisitsList;
        public System.Windows.Forms.DataGridView dgvVisitsList;
        private System.Windows.Forms.GroupBox grpVisitDetails;
        private System.Windows.Forms.Label lblDiagnosis;
        public System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblTreatment;
        public System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblReports;
        public System.Windows.Forms.TextBox txtReports;
    }
}