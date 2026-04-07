using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text.Json;
using System.Windows.Forms;

namespace Smart_Clinic_System
{
    public partial class Doctor_Panel : Form
    {
        CreatAccount account;
        PatientManager manager;

        public Doctor_Panel(CreatAccount myAccount)
        {
            InitializeComponent();
            account = myAccount;
            manager = new PatientManager();

            lblDoctorName.Text = $"Doctor: [ {account.info.name} ]";
            RefreshMyPatients();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalID_Add.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter Patient Name and National ID.");
                return;
            }

            visit newVisit = new visit
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd"),
                Diagnosis = txtDiagnosis.Text,
                Treatment = txtTreatment.Text,
                Report = txtReports.Text
            };

            manager.AddOrUpdateVisit(txtNationalID_Add.Text, txtName.Text, txtPhone.Text, newVisit, account);

            MessageBox.Show("Visit saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputs();
            RefreshMyPatients();
        }

        private void btnSearchFollow_Click(object sender, EventArgs e)
        {
            string searchID = txtNationalID_Search.Text;
            var patientRecord = manager.GetPatientById(searchID);

            if (patientRecord != null)
            {
                var myDoctorEntry = patientRecord.patients.Doctors.FirstOrDefault(d => d.NationalID == account.id);

                if (myDoctorEntry != null)
                {
                    dgvVisits.DataSource = new List<object> { new {
                        Patient = patientRecord.patients.FullName,
                        ID = patientRecord.patients.NationalID,
                        Phone = patientRecord.patients.PhoneNumber
                    }}.ToList();
                }
                else
                {
                    dgvVisits.DataSource = new List<object>();
                    MessageBox.Show("You have no previous visits recorded for this patient.");
                }
            }
            else
            {
                dgvVisits.DataSource = new List<object>();
                MessageBox.Show("Patient not found in the system.");
            }
        }

        private void dgvVisits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedID = dgvVisits.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                var patientData = manager.GetPatientById(selectedID);

                if (patientData != null)
                {
                    txtName.Text = patientData.patients.FullName;
                    txtNationalID_Add.Text = patientData.patients.NationalID;
                    txtPhone.Text = patientData.patients.PhoneNumber;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedID = txtNationalID_Add.Text;
            var patientData = manager.GetPatientById(selectedID);

            if (patientData != null)
            {
                PatientDetails detailsForm = new PatientDetails(patientData, account);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please search for or select a patient first to view full history.");
            }
        }

        private void RefreshMyPatients()
        {
            var myPatients = manager.PatientsData
                .Where(r => r.patients.Doctors.Any(d => d.NationalID == account.id))
                .Select(r => new
                {
                    Name = r.patients.FullName,
                    ID = r.patients.NationalID,
                    Phone = r.patients.PhoneNumber
                }).ToList();

            dgvVisits.DataSource = myPatients;
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtNationalID_Add.Clear();
            txtPhone.Clear();
            txtDiagnosis.Clear();
            txtTreatment.Clear();
            txtReports.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Close();
        }

        private void Doctor_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Application.Exit();
            }
        }
    }

    //============================================================================================================================

    public class PatientManager
    {
        private const string FileName = "PatientsFile.json";
        public List<recordData> PatientsData { get; private set; }

        public PatientManager()
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(FileName))
                {
                    string json = File.ReadAllText(FileName);
                    PatientsData = JsonSerializer.Deserialize<List<recordData>>(json) ?? new List<recordData>();
                }
                else
                {
                    PatientsData = new List<recordData>();
                }
            }
            catch
            {
                PatientsData = new List<recordData>();
            }
        }

        public void SaveData()
        {
            try
            {
                string json = JsonSerializer.Serialize(PatientsData, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FileName, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        public recordData GetPatientById(string nationalId)
        {
            if (PatientsData == null) return null;
            return PatientsData.FirstOrDefault(p => p.patients != null && p.patients.NationalID == nationalId);
        }

        public void AddOrUpdateVisit(string nationalId, string name, string phone, visit newVisit, CreatAccount doctorAccount)
        {
            var foundPatient = GetPatientById(nationalId);

            if (foundPatient != null)
            {
                var foundDoctor = foundPatient.patients.Doctors.FirstOrDefault(d => d.NationalID == doctorAccount.id);

                if (foundDoctor != null)
                {
                    foundDoctor.Visits.Add(newVisit);
                }
                else
                {
                    foundPatient.patients.Doctors.Add(CreateDoctorEntry(doctorAccount, newVisit));
                }
            }
            else
            {
                var newRecord = new recordData
                {
                    patients = new patient
                    {
                        FullName = name,
                        NationalID = nationalId,
                        PhoneNumber = phone,
                        Doctors = new List<doctor> { CreateDoctorEntry(doctorAccount, newVisit) }
                    }
                };
                PatientsData.Add(newRecord);
            }
            SaveData();
        }

        private doctor CreateDoctorEntry(CreatAccount acc, visit v)
        {
            return new doctor
            {
                FullName = acc.info.name,
                NationalID = acc.id,
                PhoneNumber = acc.info.phone,
                Specialty = acc.info.specialty,
                ClinicName = acc.info.clinicName,
                Visits = new List<visit> { v }
            };
        }
    }
}