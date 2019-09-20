using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_SM126215.Models
{
    public class Property
    {
        public int propertyID { get; set; }
        public string address { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public ICollection<Rental> Rental { get; set; }
    }
}