using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_SM126215.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Display (Name = "First Name")]
        [Required(ErrorMessage ="Student first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display (Name = "Last Name")]
        [Required(ErrorMessage = "Student last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Student Name")]
        public string fullName { get { return firstName + " " + lastName; } }
        [Display (Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        
        public string phoneNumber { get; set; }
        [Display (Name = "Permanent Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        public string permanentAddress { get; set; }
        [Display (Name = "Permanent State")]
        [Required(ErrorMessage = "State is required")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be two characters")]
        public string permanentState { get; set; }
        [Display (Name = "Permanent Zip Code")]
        [Required(ErrorMessage = "Zip Code is required")]
        [StringLength(20)]
        public string permanentZip { get; set; }
        public ICollection<Rental> Rental { get; set; }
    }
}