﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pro_1_MVC_Learning.Models
{
    public class DB_Class:DbContext
    {
        public DB_Class():base("DB") { }
        public DbSet<Person> People { get; set; }

        public System.Data.Entity.DbSet<Pro_1_MVC_Learning.Models.News> News { get; set; }
    }
}