namespace Smart_Clinic_System
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        // Panels
        private Panel panelLogin;

        // Login controls
        private Label titleLogin;
        private Label labelUser;
        private Label labelPass;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelLogin = new Panel();
            ResetPassword = new Button();
            titleLogin = new Label();
            labelUser = new Label();
            txtUsername = new TextBox();
            labelPass = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnBack = new Button();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(ResetPassword);
            panelLogin.Controls.Add(titleLogin);
            panelLogin.Controls.Add(labelUser);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(labelPass);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(btnBack);
            panelLogin.Location = new Point(0, 0);
            panelLogin.Margin = new Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(479, 438);
            panelLogin.TabIndex = 0;
            // 
            // ResetPassword
            // 
            ResetPassword.BackColor = Color.Red;
            ResetPassword.FlatAppearance.BorderSize = 0;
            ResetPassword.FlatStyle = FlatStyle.Flat;
            ResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ResetPassword.ForeColor = Color.White;
            ResetPassword.Location = new Point(160, 383);
            ResetPassword.Margin = new Padding(3, 4, 3, 4);
            ResetPassword.Name = "ResetPassword";
            ResetPassword.Size = new Size(160, 34);
            ResetPassword.TabIndex = 6;
            ResetPassword.Text = "Reset Password";
            ResetPassword.UseVisualStyleBackColor = false;
            ResetPassword.Click += ResetPassword_Click;
            // 
            // titleLogin
            // 
            titleLogin.AutoSize = true;
            titleLogin.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            titleLogin.ForeColor = Color.FromArgb(0, 120, 215);
            titleLogin.Location = new Point(114, 45);
            titleLogin.Name = "titleLogin";
            titleLogin.Size = new Size(201, 41);
            titleLogin.TabIndex = 0;
            titleLogin.Text = "Doctor Login";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9F);
            labelUser.Location = new Point(69, 125);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(134, 15);
            labelUser.TabIndex = 1;
            labelUser.Text = "Username or ID or Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(69, 158);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(342, 25);
            txtUsername.TabIndex = 0;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 9F);
            labelPass.Location = new Point(69, 212);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(57, 15);
            labelPass.TabIndex = 2;
            labelPass.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(69, 245);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(342, 25);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(111, 306);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(251, 53);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.Location = new Point(11, 13);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 40);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(479, 438);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic System - Access";
            FormClosing += Login_FormClosing;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        private Button ResetPassword;
    }
}