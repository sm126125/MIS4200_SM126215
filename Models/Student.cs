using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_SM126215.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string permanentAddress { get; set; }
        public string permanentState { get; set; }
        public string permanentZip { get; set; }
        public ICollection<Rental> Rental { get; set; }
    }
}