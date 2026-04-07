using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Clinic_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Close();
        }

        // عند الضغط علي زر تسجيل الدخول يتم فحص البيانات المدخلة من خلال ميثود login وفي حالة كانت صحيحة يتم فتح صفحة الطبيب الخاصة بيه
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login(txtUsername.Text, txtPassword.Text);
        }
        //ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ

        private void ResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword res = new ResetPassword();
            res.ShowDialog();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.Exit();
            }
        }

        //===============================================================================================================

        private void _size(int w, int h)
        {
            this.ClientSize = new Size(w, h);
            this.CenterToScreen();
        }

        // ميثود تسجيل الدخول
        private void login(string user, string pass)
        {
            GetAccountsFromFile all = new GetAccountsFromFile();

            foreach (CreatAccount account in all.AllAccounts())
            {
                if (account.username == user || account.id == user || account.email == user)
                {
                    if (account.info.password == pass)
                    {
                        Doctor_Panel f3 = new Doctor_Panel(account);
                        f3.Show();
                        this.Close();
                        return;
                    }
                    MessageBox.Show("كلمة المرور غير صحيحة");
                    return;
                }
            }
            MessageBox.Show("اسم المستخدم او الرقم القومي او البريد الالكتروني غير صحيح");
        }
        //ــــــــــــــــــــــــ
    }
}