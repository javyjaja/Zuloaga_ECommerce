﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class EComemrceContext : DbContext
    {
        public EComemrceContext() :base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Ecommerce.Models.Department> Departments { get; set; }
    }
}