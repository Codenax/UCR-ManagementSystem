﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCR_ManagementSystem.Models.Models;
namespace UCR_ManagementSystem.DatabaseContexts.DatabaseContext
{
    public class URCMsDbContext : DbContext
    {
        public URCMsDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Department> Departments { get; set; }
    }
}
