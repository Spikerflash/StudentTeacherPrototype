using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentTeacherPrototype.Models
{
    public class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }

    public class StaffDBContext : DbContext
    {
        public StaffDBContext()
        { }
        public DbSet<Staff> Employees { get; set; }
    }
}