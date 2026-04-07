namespace Smart_Clinic_System
{
    partial class ResetPassword
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
            panelLogin = new Panel();
            label3 = new Label();
            textPhone = new TextBox();
            label2 = new Label();
            textID = new TextBox();
            label1 = new Label();
            textEmail = new TextBox();
            button1 = new Button();
            titleLogin = new Label();
            labelUser = new Label();
            txtUsername = new TextBox();
            labelPass = new Label();
            txtPassword = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(textPhone);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(textID);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(textEmail);
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(titleLogin);
            panelLogin.Controls.Add(labelUser);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(labelPass);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Location = new Point(0, 2);
            panelLogin.Margin = new Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(440, 557);
            panelLogin.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(45, 321);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "Phone";
            // 
            // textPhone
            // 
            textPhone.Font = new Font("Segoe UI", 10F);
            textPhone.Location = new Point(45, 354);
            textPhone.Margin = new Padding(3, 4, 3, 4);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(342, 30);
            textPhone.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(44, 169);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // textID
            // 
            textID.Font = new Font("Segoe UI", 10F);
            textID.Location = new Point(44, 202);
            textID.Margin = new Padding(3, 4, 3, 4);
            textID.Name = "textID";
            textID.Size = new Size(342, 30);
            textID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(45, 246);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 10F);
            textEmail.Location = new Point(45, 279);
            textEmail.Margin = new Padding(3, 4, 3, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(342, 30);
            textEmail.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(133, 490);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 39);
            button1.TabIndex = 6;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Reset_Click;
            // 
            // titleLogin
            // 
            titleLogin.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            titleLogin.ForeColor = Color.FromArgb(0, 120, 215);
            titleLogin.Location = new Point(12, 25);
            titleLogin.Name = "titleLogin";
            titleLogin.Size = new Size(415, 50);
            titleLogin.TabIndex = 0;
            titleLogin.Text = "Reset Password";
            titleLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9F);
            labelUser.Location = new Point(42, 91);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(75, 20);
            labelUser.TabIndex = 1;
            labelUser.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(42, 124);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(342, 30);
            txtUsername.TabIndex = 0;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 9F);
            labelPass.Location = new Point(42, 401);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(104, 20);
            labelPass.TabIndex = 2;
            labelPass.Text = "New Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(42, 434);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(342, 30);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 559);
            Controls.Add(panelLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ResetPassword";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label label3;
        private TextBox textPhone;
        private Label label2;
        private TextBox textID;
        private Label label1;
        private TextBox textEmail;
        private Button button1;
        private Label titleLogin;
        private Label labelUser;
        private TextBox txtUsername;
        private Label labelPass;
        private TextBox txtPassword;
    }
}