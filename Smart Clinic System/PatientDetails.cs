using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Clinic_System
{
    public partial class PatientDetails : Form
    {
        private recordData _patient;
        private CreatAccount _doctor;

        public PatientDetails(recordData patient, CreatAccount doctor)
        {
            InitializeComponent();
            _patient = patient;
            _doctor = doctor;

            lblNameValue.Text = _patient.patients.FullName;
            lblIDValue.Text = _patient.patients.NationalID;

            LoadVisitDates();
        }

        private void LoadVisitDates()
        {
            var doctorData = _patient.patients.Doctors.FirstOrDefault(d => d.NationalID == _doctor.id);
            if (doctorData != null)
            {
                dgvVisitsList.DataSource = doctorData.Visits.Select(v => new
                {
                    Date = v.Date,
                    Diagnosis = v.Diagnosis,
                    _Treatment = v.Treatment,
                    _Report = v.Report
                }).ToList();

                if (dgvVisitsList.Columns.Contains("_Treatment")) dgvVisitsList.Columns["_Treatment"].Visible = false;
                if (dgvVisitsList.Columns.Contains("_Report")) dgvVisitsList.Columns["_Report"].Visible = false;
            }
        }

        private void dgvVisitsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisitsList.SelectedRows.Count > 0)
            {
                var row = dgvVisitsList.SelectedRows[0];
                txtDiagnosis.Text = row.Cells["Diagnosis"].Value?.ToString();
                txtTreatment.Text = row.Cells["_Treatment"].Value?.ToString();
                txtReports.Text = row.Cells["_Report"].Value?.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}