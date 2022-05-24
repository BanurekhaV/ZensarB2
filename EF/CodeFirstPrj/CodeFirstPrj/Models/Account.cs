using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstPrj.Models
{
    class Account
    {
        [Key]
        public int AccountNo { get; set; }
        public string AccountType { get; set; }

        public float AccountBalance { get; set; }
    }
}
