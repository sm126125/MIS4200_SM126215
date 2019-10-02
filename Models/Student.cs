using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_SM126215.Models
{
    public class Student
    {
        public int studentID { get; set; }
        [Display (Name = "First Name")]
        public string firstName { get; set; }
        [Display (Name = "Last Name")]
        public string lastName { get; set; }
        [Display (Name = "Phone Number")]
        public string phoneNumber { get; set; }
        [Display (Name = "Permanent Address")]
        public string permanentAddress { get; set; }
        [Display (Name = "Permanent State")]
        public string permanentState { get; set; }
        [Display (Name = "Permanent Zip Code")]
        public string permanentZip { get; set; }
        public ICollection<Rental> Rental { get; set; }
    }
}