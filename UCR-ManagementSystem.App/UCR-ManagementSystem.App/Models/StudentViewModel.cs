﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace UCR_ManagementSystem.App.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Student Name Is Required")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        [Display(Name = "Email ")]
        [EmailAddress(ErrorMessage = "Provide a Valid Email Address")]
        public string StudentEmail { get; set; }

        [Required(ErrorMessage = "Contact No Is Required")]
        [Display(Name = "Contact No")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Contact No must be 11 characters")]
        public long StudentContactNo { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegData { get; set; }

        [Required(ErrorMessage = "Address  Is Required")]
        [Display(Name = "Address ")]
        public string StudentAddress { get; set; }
        [Required(ErrorMessage = "Department Is Required")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        //public string RegistrationNumber { get; set; }
        public int CourseId { get; set; }

        public IEnumerable<SelectListItem> RegistrationNumberList { get; set; }

        public IEnumerable<SelectListItem> CoursetSelectListItems { get; set; }

        public IEnumerable<SelectListItem> DepartmentSelectListItems { get; set; }
    }
}