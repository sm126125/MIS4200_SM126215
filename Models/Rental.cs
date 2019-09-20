using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_SM126215.Models
{
    public class Rental
    {
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
        public int propertyID { get; set; }
        public virtual Property Property { get; set; }
        public int RentalID { get; set; }
        public Decimal monthlyRent { get; set; }

    }
}