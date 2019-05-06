namespace MVCDemo2.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HMSContext : DbContext
    {
        public HMSContext()
            : base("HMSContext")
        {
        }
        public DbSet<Patient> Patients { get; set; }

    }

}