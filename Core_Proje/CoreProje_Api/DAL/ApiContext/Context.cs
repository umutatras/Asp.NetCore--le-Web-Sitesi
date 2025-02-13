﻿using CoreProje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreProje_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2GOA1TF;database=CoreProjeDb2;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }

}
