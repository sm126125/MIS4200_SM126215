using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MIS4200_SM126215.Models
{
    public class Property
    {
        public int propertyID { get; set; }
        [Display (Name = "Address")]
        public string address { get; set; }
        [Display (Name = "Street")]
        public string street { get; set; }
        [Display (Name = "City")]
        public string city { get; set; }
        [Display (Name = "State")]
        public string state { get; set; }
        [Display (Name = "Zip Code")]
        public string zipCode { get; set; }
        [Display (Name = "Rental Start Date")]
        
        public DateTime startTime { get; set; }
        [Display (Name = "Rental End Date")]
        public DateTime endTime { get; set; }
        public ICollection<Rental> Rental { get; set; }

    }
}