using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject
{
   public class EmployeeBAL
    {
        ////1. with constructor injection
        //public IEmployeeDAL iempdal;

        //public EmployeeBAL(IEmployeeDAL empdalargument) //EmployeeDAL-services class is injected
        //{
        //   iempdal = empdalargument;
        //}

        //public List<Employee> EmployeeDetails()
      //  {
          
       //     return iempdal.GetAllEmployees();
       // }

    //2. with property injection
    //private IEmployeeDAL iempdal;

    //public IEmployeeDAL _EmployeeObject
    //{
    //    set
    //    {
    //        //this.iempdal = value;
    //        iempdal = value;
    //    }
    //    get
    //    {
    //        return iempdal;
    //    }
    //}

    //public List<Employee> EmployeeDetails()
    //{
    //   
    //    return iempdal.GetAllEmployees();
    //}

    //3. DI thru Method
    public IEmployeeDAL iempdal;
        public List<Employee> EmployeeDetails(IEmployeeDAL iedal) // DI in a method
        {
            iempdal = iedal;
            return iempdal.GetAllEmployees();
        }

        public Employee GetOneEmployee()
        {
            return iempdal.GetOneEmployee();
        }
    }
}
