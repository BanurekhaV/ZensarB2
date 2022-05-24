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
        Product p = new Product();
        static tblEmployee emp = new tblEmployee();

        public void addEmp()
        {
            Console.WriteLine("Enter employee details");
            emp.Empid = Convert.ToInt32(Console.ReadLine());
            emp.EmpName = Console.ReadLine();
            emp.Gender = Console.ReadLine();
            emp.Salary = float.Parse(Console.ReadLine());
            emp.Email = Console.ReadLine();
            emp.Phoneno = Console.ReadLine();
            emp.DId = Convert.ToInt32(Console.ReadLine());
            dbcontext.tblEmployees.Add(emp);
            dbcontext.SaveChanges();
        }

        public void delEmployee(int eid)
        {
            var e = dbcontext.tblEmployees.ToList();
            emp = e.Find(x => x.Empid == eid);
            if (emp != null)
            {
                dbcontext.tblEmployees.Remove(emp);
                int res = dbcontext.SaveChanges();
                Console.WriteLine("Delete Success");

            }
              else
              Console.WriteLine("delete not successful");
        }
         public void addproduct()
        {
            p.ProductId = 107;
            p.ProductName = "newproduct";
            p.Price = 500;
            p.QtyAvailable = 20;
            dbcontext.Products.Add(p);
            dbcontext.SaveChanges();
        }
        public void DisplayDept()
        {
            var deptlist = from d in dbcontext.tblDepartments
                           select d;

            foreach (var v in deptlist)
            {
                Console.WriteLine(v.DeptId + "  " + v.DeptName + "  " + v.Loc_City);
            }
        }

        public void add_and_ShowDept()
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

            List<tblDepartment> deptlist = dbcontext.tblDepartments.ToList();
            foreach (var v in deptlist)
            {
                Console.WriteLine(v.DeptId + "  " + v.DeptName + "  " + v.Loc_City);
            }
        }

        public void sort_Employee()
        {
            var e = dbcontext.tblEmployees.ToList();
            var sorted_emp = e.OrderByDescending(a => a.EmpName);

            foreach(var item in sorted_emp)
            {
                Console.WriteLine($"{item.EmpName}");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            // program.addproduct();
          //  program.addEmp();
           // Console.WriteLine("Emp id to delete :");
           // int eid = int.Parse(Console.ReadLine());
           // program.delEmployee(eid);
            program.sort_Employee();
            Console.Read();
        }
    }
}
