﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCR_ManagementSystem.Models.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public double CourseCredit { get; set; }
        public string CourseDescription { get; set; }
        public string Semester { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        //public AssignTeacher AssignTeacher { get; set; }
        [NotMapped]
        public static List<Course> CourseList { get; set; }
       
    }
    
}
