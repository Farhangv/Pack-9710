namespace WebApp
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class UniversityModel : DbContext
    {
        public UniversityModel()
            : base("UniversityModel")
        {
        }
        public DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        [MaxLength(1)]
        public string Gender { get; set; }
        public string Degree { get; set; }
        public string Courses { get; set; }
        public string Description { get; set; }
        public string PhotoFilePath { get; set; }
    }
}