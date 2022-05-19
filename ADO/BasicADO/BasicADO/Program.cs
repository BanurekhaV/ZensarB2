using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BasicADO
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
           //
           //SelectData();
            GetScalarFunc();
            Console.Read();
        }

        public static void GetScalarFunc()
        {
            con = getCon();
            cmd = new SqlCommand("select count(Empid) from tblemployee", con);
            int empcount = Convert.ToInt32(cmd.ExecuteScalar()); // execute scalar returns object
            Console.WriteLine("No.of Employees :{0}",empcount);
        }
        public static void SelectData()
        {
            con = getCon();
            // cmd = new SqlCommand("select * from tblemployee", con);
            //or
            cmd = new SqlCommand("Select * from tblEmployee");
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                // Console.WriteLine(dr[0] + " "+ dr[1]+" " + dr[2] + " " + dr[3]);
                //or
                Console.WriteLine("Employee Id : " + dr[0]);
                Console.WriteLine("Employee Name : " + dr[1]);
                Console.WriteLine("Employee Gender : " + dr[2]);
                Console.WriteLine("Employee Salary : " + dr[3]);
            }

        }

        public static SqlConnection getCon()
        {
            con = new SqlConnection("data source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=ZensarDB;" +
              "Integrated Security=true;");
            //new SqlConnection("data source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=ZensarDB;" +
            //user id=sa; password=   ");
            con.Open();
            return con;
        }
    }
}
