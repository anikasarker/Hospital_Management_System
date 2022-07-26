﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Specialization { get; set; }
        public float Year_Of_Experience { get; set; }

    }
}
