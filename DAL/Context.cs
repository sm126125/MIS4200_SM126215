using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200_SM126215.Models;
using System.Data.Entity;

namespace MIS4200_SM126215.DAL
{
    public class Context : DbContext
    {
        public Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context,
            MIS4200_SM126215.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}