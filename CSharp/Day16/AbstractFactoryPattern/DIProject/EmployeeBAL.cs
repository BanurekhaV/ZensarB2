using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject
{
   public class EmployeeBAL
    {
        public IEmployeeDAL iempdal;

        public EmployeeBAL(IEmployeeDAL empdalargument) //EmployeeDAL-services class is injected
        {
           iempdal = empdalargument;
        }

        public List<Employee> EmployeeDetails()
        {
            return iempdal.GetAllEmployees();
        }
    }
}
