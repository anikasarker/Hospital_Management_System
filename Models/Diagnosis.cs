using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Diagnosis
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Disease { get; set; }
        public string Symptoms { get; set; }
        public string Medicine { get; set; }
    }
}
