using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class PatientInformation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public string Blood_Group { get; set; }
        public string Disease { get; set; }
        public string Occupation { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    }
}
