using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MIS4200_SM126215.Models
{
    public class Property
    {
        [Key]
        public int propertyID { get; set; }
        [Display (Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(20)]
        public string address { get; set; }
        [Display (Name = "Street")]
        [Required(ErrorMessage = "Street is required")]
        [StringLength(100)]
        public string street { get; set; }
        [Display (Name = "City")]
        [Required(ErrorMessage = "City is required")]
        [StringLength(100)]
        public string city { get; set; }
        [Display (Name = "State")]
        [Required(ErrorMessage = "State is required")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be two characters")]
        public string state { get; set; }
        [Display (Name = "Zip Code")]
        [Required(ErrorMessage = "Zip Code is required")]
        [StringLength(20)]
        public string zipCode { get; set; }
        [Display (Name = "Rental Start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        
        public DateTime startTime { get; set; }
        [Display (Name = "Rental End Date")]
        [Required(ErrorMessage = "End Date is required")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]

        public DateTime endTime { get; set; }
        public ICollection<Rental> Rental { get; set; }

    }
}