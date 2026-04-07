using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

//هذا الكلاس خاص بإنشاء حساب جديد للدكاترة وتخزينه في ملف جيسون
namespace Smart_Clinic_System
{
    //هذا الكلاس هو الام الذي يحتوي علي كل شئ عن بالدكتور
    public class CreatAccount
    {
        public static char[] Check = new char[8];
        private string ID, Email, Username;
        public String id
        {
            get { return ID; }
            set
            {
                if (value.Length == 14) { ID = value; Check[1] = 'T'; }
                else Check[1] = 'F';
            }
        }
        public string email
        {
            get { return Email; }
            set
            {
                if (value.Length > 15 && value.EndsWith("@gmail.com")) { Email = value; Check[5] = 'T'; }
                else Check[5] = 'F';
            }
        }
        public string username
        {
            get { return Username; }
            set
            {
                if (value.Length > 4) { Username = value; Check[6] = 'T'; }
                else Check[6] = 'F';
            }
        }
        public Info info { get; set; } = new Info();
    }

    // هذا الكلاس الذي يحتوي علي المعلومات الشخصية للدكتور
    public class Info
    {
        private string Name, Phone, Specialty, ClinicName, Password;

        public string name
        {
            get { return Name; }
            set
            {
                if (value.Length > 3) { Name = value; CreatAccount.Check[0] = 'T'; }
                else CreatAccount.Check[0] = 'F';
            }
        }
        public string phone
        {
            get { return Phone; }
            set
            {
                if (value.Length == 11) { Phone = value; CreatAccount.Check[2] = 'T'; }
                else CreatAccount.Check[2] = 'F';
            }
        }
        public string specialty
        {
            get { return Specialty; }
            set
            {
                if (value.Length > 3) { Specialty = value; CreatAccount.Check[3] = 'T'; }
                else CreatAccount.Check[3] = 'F';
            }
        }
        public string clinicName
        {
            get { return ClinicName; }
            set
            {
                if (value.Length > 3) { ClinicName = value; CreatAccount.Check[4] = 'T'; }
                else CreatAccount.Check[4] = 'F';
            }
        }
        public string password
        {
            get { return Password; }
            set
            {
                if (value.Length > 5) { Password = value; CreatAccount.Check[7] = 'T'; }
                else CreatAccount.Check[7] = 'F';
            }
        }

    }

    //هذا الكلاس خاص بقراءة كل الحسابات الموجودة في ملف جيسون وتحويلها الي List من نوع CreatAccount
    class GetAccountsFromFile
    {
        public CreatAccount[] AllAccounts()
        {
            if (File.Exists("DoctorAccount.json"))
            {
                string json = File.ReadAllText("DoctorAccount.json");
                return JsonSerializer.Deserialize < CreatAccount[]>(json);
            }
            return new CreatAccount[0];
        }
    }
}