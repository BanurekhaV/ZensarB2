using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Day3Model_Validations.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="First Name is Required")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="FirstName to be between 4 and 20 characters only")]
        [Display(Name ="First Name")]
        public string EmpFName { get; set; }
        [Required]
        
        public string EmpLName { get; set; }
        [Range(typeof(DateTime),"01-01-1970","01-01-2005",ErrorMessage ="Date of Birth must be between 01-01-1975 and 01-01-2015")]
        public DateTime DOB { get; set; }
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-Za-z]+)|([A-Za-z]+))$")]
        public string UserName { get; set; }
        [MinLength(5,ErrorMessage ="The password has to be minimum 5 charcters")]
        [MaxLength(10, ErrorMessage = "The password has to be max 10 charcters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}