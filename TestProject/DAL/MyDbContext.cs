using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestProject.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestProject.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbContext") { }


        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Timetable> Timetables { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}