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

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<Property> Property { get; set; }
        
    }
}