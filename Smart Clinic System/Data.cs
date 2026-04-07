using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Clinic_System
{
    public class parson
    {
        public string NationalID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class visit
    {
        public string Date { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Report { get; set; }
    }

    public class doctor : parson
    {
        public string Specialty { get; set; }
        public string ClinicName { get; set; }
        public List<visit> Visits { get; set; } = new List<visit>();
    }

    public class patient : parson
    {
        public List<doctor> Doctors { get; set; } = new List<doctor>();
    }

    public class recordData
    {
        public patient patients { get; set; }
    }
}