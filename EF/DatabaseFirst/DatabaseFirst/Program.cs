using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static ZensarDBEntities dbcontext = new ZensarDBEntities();
        static tblDepartment tdept = new tblDepartment();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dept Id :");
            tdept.DeptId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DeptName :");
            tdept.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Dept City :");
            tdept.Loc_City = Console.ReadLine();
            dbcontext.tblDepartments.Add(tdept);
            dbcontext.SaveChanges();
            Console.WriteLine("Added a Dept successfully");

            //List<tblDepartment> deptlist = dbcontext.tblDepartments.ToList();
            //foreach(var v in deptlist)
            //{
            //    Console.WriteLine(v.DeptId + "  "+ v.DeptName + "  " + v.Loc_City);
            //}

            var deptlist = from d in dbcontext.tblDepartments
                           select d;

            foreach (var v in deptlist)
               {
                   Console.WriteLine(v.DeptId + "  "+ v.DeptName + "  " + v.Loc_City);
               }
                Console.Read();
        }
    }
}
