﻿using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data.Entity;
using UCR_ManagementSystem.DatabaseContexts.DatabaseContext;
using UCR_ManagementSystem.Models.Models;

namespace UCR_ManagementSystem.DAL.DAL
{
    public class DepartmentDAL
    {

        UCRMSystemDbContext db = new UCRMSystemDbContext();
        public bool Add(Department department)
        {
            if (db.Departments.FirstOrDefault(c => c.DepartmentName.ToLower().Contains(department.DepartmentName.ToLower())) == null && db.Departments.FirstOrDefault(c => c.DepartmentCode.ToLower().Contains(department.DepartmentCode.ToLower())) == null)
            {
                db.Departments.Add(department);
                return db.SaveChanges() > 0;
            }
            else
            {
                return false;
            }


        }
        public List<Department> GetAll()
        {
            return db.Departments
                .Include(c => c.Courses)
                .ToList();
        }
        //public List<Department> GetAll()
        //{
        //    return db.Departments
        //        .Include(c => c.Employees)
        //        .ToList();
        //}

        public Department GetById(int id)
        {
            return db.Departments.SingleOrDefault(c => c.Id == id);
        }
    }

}
