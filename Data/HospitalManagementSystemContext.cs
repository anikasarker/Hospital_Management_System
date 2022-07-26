using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Data
{
    public class HospitalManagementSystemContext : DbContext
    {
        public HospitalManagementSystemContext (DbContextOptions<HospitalManagementSystemContext> options)
            : base(options)
        {
        }

       

        public DbSet<HospitalManagementSystem.Models.Diagnosis> Diagnosis { get; set; }

       

       /// public DbSet<HospitalManagementSystem.Models.Patient_Information> Patient_Information { get; set; }

       

       // public DbSet<HospitalManagementSystem.Models.Doctor> Doctor { get; set; }

       

       /// public DbSet<HospitalManagementSystem.Models.Patient_Information> Patient_Information { get; set; }

       

        public DbSet<HospitalManagementSystem.Models.PatientInformation> PatientInformation { get; set; }

       

       /// public DbSet<HospitalManagementSystem.Models.Patient_Information> Patient_Information { get; set; }

       

       // public DbSet<HospitalManagementSystem.Models.Doctor> Doctor { get; set; }

       

       /// public DbSet<HospitalManagementSystem.Models.Patient_Information> Patient_Information { get; set; }

       

        public DbSet<HospitalManagementSystem.Models.Doctor> Doctor { get; set; }

    }
}
