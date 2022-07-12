using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto_escuela_ico.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
    }
}