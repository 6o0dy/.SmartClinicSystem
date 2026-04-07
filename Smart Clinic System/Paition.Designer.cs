namespace Smart_Clinic_System
{
    partial class Patient
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
            panelPatient = new Panel();
            titlePatient = new Label();
            txtPatientNID = new TextBox();
            btnSearchPatient = new Button();
            btnPatientBack = new Button();
            panelPatient.SuspendLayout();
            SuspendLayout();
            // 
            // panelPatient
            // 
            panelPatient.BackColor = Color.White;
            panelPatient.Controls.Add(titlePatient);
            panelPatient.Controls.Add(txtPatientNID);
            panelPatient.Controls.Add(btnSearchPatient);
            panelPatient.Controls.Add(btnPatientBack);
            panelPatient.Location = new Point(1, 1);
            panelPatient.Margin = new Padding(3, 4, 3, 4);
            panelPatient.Name = "panelPatient";
            panelPatient.Size = new Size(463, 274);
            panelPatient.TabIndex = 3;
            // 
            // titlePatient
            // 
            titlePatient.AutoSize = true;
            titlePatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titlePatient.ForeColor = Color.FromArgb(0, 120, 215);
            titlePatient.Location = new Point(130, 54);
            titlePatient.Name = "titlePatient";
            titlePatient.Size = new Size(177, 32);
            titlePatient.TabIndex = 0;
            titlePatient.Text = "Patient Access";
            // 
            // txtPatientNID
            // 
            txtPatientNID.Font = new Font("Segoe UI", 12F);
            txtPatientNID.Location = new Point(46, 123);
            txtPatientNID.Margin = new Padding(3, 4, 3, 4);
            txtPatientNID.Name = "txtPatientNID";
            txtPatientNID.PlaceholderText = "Enter National ID";
            txtPatientNID.Size = new Size(365, 29);
            txtPatientNID.TabIndex = 1;
            // 
            // btnSearchPatient
            // 
            btnSearchPatient.BackColor = Color.FromArgb(0, 120, 215);
            btnSearchPatient.FlatAppearance.BorderSize = 0;
            btnSearchPatient.FlatStyle = FlatStyle.Flat;
            btnSearchPatient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearchPatient.ForeColor = Color.White;
            btnSearchPatient.Location = new Point(109, 191);
            btnSearchPatient.Margin = new Padding(3, 4, 3, 4);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(229, 53);
            btnSearchPatient.TabIndex = 2;
            btnSearchPatient.Text = "View Medical Record";
            btnSearchPatient.UseVisualStyleBackColor = false;
            btnSearchPatient.Click += btnSearchPatient_Click;
            // 
            // btnPatientBack
            // 
            btnPatientBack.FlatStyle = FlatStyle.Flat;
            btnPatientBack.Font = new Font("Segoe UI", 9F);
            btnPatientBack.Location = new Point(11, 13);
            btnPatientBack.Margin = new Padding(3, 4, 3, 4);
            btnPatientBack.Name = "btnPatientBack";
            btnPatientBack.Size = new Size(80, 40);
            btnPatientBack.TabIndex = 3;
            btnPatientBack.Text = "Back";
            btnPatientBack.Click += btnPatientBack_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 272);
            Controls.Add(panelPatient);
            MaximizeBox = false;
            Name = "Patient";
            ShowIcon = false;
            Text = "Paition";
            FormClosing += Paition_FormClosing;
            panelPatient.ResumeLayout(false);
            panelPatient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPatient;
        private Label titlePatient;
        private TextBox txtPatientNID;
        private Button btnSearchPatient;
        private Button btnPatientBack;
    }
}