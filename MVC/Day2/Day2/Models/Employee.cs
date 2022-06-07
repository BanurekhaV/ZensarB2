using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day2.Models
{
    //model validations
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name ="Employee Name :")]
        public string Name { get; set; } 
        [DisplayName("Date of Joining")]
        public Nullable<System.DateTime> DOJ { get; set; }
        public string Email { get; set; }
    }
}