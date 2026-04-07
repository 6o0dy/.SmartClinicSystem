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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnPatientBack_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Close();
        }

        private void Paition_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.Exit();
            }
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
