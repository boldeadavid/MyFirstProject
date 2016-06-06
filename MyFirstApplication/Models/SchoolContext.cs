using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstApplication.Models
{
    public class SchoolContext:DbContext
    { 
        //enables CRUD func
        public DbSet<Student> Students { get; set; }
    }
}