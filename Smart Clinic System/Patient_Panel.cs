using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Clinic_System
{
    public partial class Patient_Panel : Form
    {
        public Patient_Panel()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم تحديث القائمة.");
        }

        private void Patient_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.Exit();
            }
        }

        private void Patient_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
