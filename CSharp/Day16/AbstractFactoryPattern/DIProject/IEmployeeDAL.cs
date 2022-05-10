using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject
{
    public interface IEmployeeDAL
    {
        List<Employee> GetAllEmployees();
    }
}
