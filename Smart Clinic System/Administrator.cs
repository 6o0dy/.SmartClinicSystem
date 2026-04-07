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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // انشاء كائن جديد من نوع CreatAccount ويتم تمرير البيانات المدخله من خلاله ليتم فحصها
            CreatAccount account = new CreatAccount
            {
                id = txtID.Text,
                email = txtEmail.Text,
                username = txtUserNew.Text,
                info = new Info
                {
                    name = txtName.Text,
                    phone = txtPhone.Text,
                    clinicName = txtClinic.Text,
                    specialty = txtSpec.Text,
                    password = txtPassNew.Text
                }
            };

            // يتم فحص البيانات المدخلة من خلال ميثود ValidateData وفي حالة كانت صحيحة يتم اضافة الحساب الجديد الي ملف جيسون الخاص بالحسابات
            if (ValidateData())
            {
                GetAccountsFromFile all = new GetAccountsFromFile();

                CreatAccount[] allAccounts = all.AllAccounts();
                Array.Resize(ref allAccounts, allAccounts.Length + 1);
                allAccounts[allAccounts.Length - 1] = account;

                string updatedJson = JsonSerializer.Serialize(allAccounts, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("DoctorAccount.json", updatedJson);

                MessageBox.Show("تم انشاء الحساب بنجاح!");
            }
        }

        // ميثود لعرض الاخطاء التي حدثت في عملية انشاء الحساب
        private bool ValidateData()
        {
            bool isValid = true;
            string error = "";
            for (int i = 0; i < CreatAccount.Check.Length; i++)
            {
                string errorMessage = i switch
                {
                    0 => "لقب المستخدم لازم علي الاقل 4 حروف",
                    1 => "الرقم القومي لازم يكون 14 رقم",
                    2 => "رقم الهاتف لازم يكون 11 رقم",
                    3 => "التخصص لازم علي الاقل 5 حروف",
                    4 => "اسم العيادة لازم علي الاقل 5 حروف",
                    5 => "الايميل لازم يحتوي في الاخر علي '@gmail.com'.",
                    6 => "اسم المستخدم لازم يكون علي الاقل 4 حروف",
                    7 => "الباسورد يجب ان لا يقل عن 6 ارقام او حروف",
                    _ => $"Field {i + 1} is invalid."
                };
                if (CreatAccount.Check[i] == 'F')
                {
                    error += errorMessage + "\n";
                    isValid = false;
                }
                if (!isValid && i == CreatAccount.Check.Length - 1)
                {
                    MessageBox.Show(error);
                    return isValid;
                }
            }
            return isValid;
        }
        //ــــــــــــــــــــــــــــــــــــــــــــــــ

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.Exit();
            }
        }

        private void btnCreateBack_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Close();
        }
    }
}
