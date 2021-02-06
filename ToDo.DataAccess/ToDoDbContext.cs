using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ToDo.Entities;

namespace ToDo.DataAccess
{
    public class ToDoDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ToDoDb;Integrated Security=True");
        }

        public DbSet<Item> Items { get; set; }
    }
}
