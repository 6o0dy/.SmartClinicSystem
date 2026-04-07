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
using static System.Net.Mime.MediaTypeNames;

namespace Smart_Clinic_System
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Reset(txtUsername.Text, textID.Text, textEmail.Text, textPhone.Text, txtPassword.Text);
        }

        private void Reset(string user, string id, string email, string phone, string newPass)
        {
            GetAccountsFromFile all = new GetAccountsFromFile();

            CreatAccount[] account = all.AllAccounts();
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i].username == user && account[i].id == id && account[i].email == email && account[i].info.phone == phone)
                {
                    if (newPass.Length > 5)
                    {
                        account[i].info.password = newPass;

                        string updatedJson = JsonSerializer.Serialize(account, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText("DoctorAccount.json", updatedJson);

                        MessageBox.Show("تم تغير كلمه المرور");
                        return;
                    }
                    MessageBox.Show("كلمه المرور يجب ان تكون اكثر من 5 حروف");
                    return;
                }
            }
            MessageBox.Show("عذرا البيانات غير صحيحه");
        }
    }
}
