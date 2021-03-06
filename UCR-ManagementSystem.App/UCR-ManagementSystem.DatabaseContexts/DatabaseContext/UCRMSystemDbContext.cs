﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCR_ManagementSystem.Models.Models;

namespace UCR_ManagementSystem.DatabaseContexts.DatabaseContext
{
   public class UCRMSystemDbContext : DbContext
    {
       public UCRMSystemDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<AssignTeacher> AssignTeachers { get; set; }
        public DbSet<StudentEnroll> StudentEnrolls { get; set; }
        public DbSet<SaveStudentResult> SaveStudentResults { get; set; }
        public DbSet<AllocateClassRoom> AllocateClassRooms { get; set; }
    }
}
