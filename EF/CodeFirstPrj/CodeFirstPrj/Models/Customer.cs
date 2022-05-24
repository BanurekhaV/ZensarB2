using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstPrj.Models
{
    class Customer
    {
        [Key]
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string Address { get; set; }
    }
}
