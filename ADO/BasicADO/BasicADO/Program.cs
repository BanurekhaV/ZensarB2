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
            // InsertProductData();
            // SelectEmployeeData();
            //  GetScalarFunc();
            DeleteProduct();
            Console.Read();
        }

        public static void DeleteProduct()
        {
            con = getCon();
            Console.WriteLine("Enter Product id to delete :");
            int pid = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("delete from product where productid=@pid", con);
            cmd.Parameters.AddWithValue("@pid", pid);
            int res=cmd.ExecuteNonQuery(); 
            if(res>0)
                Console.WriteLine("record deleted");
            else
                Console.WriteLine("Not deleted");
        }
        public static void InsertProductData()
        {
            con = getCon();
            Console.WriteLine("Enter ProductId:");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description :");
            string pdesc = Console.ReadLine();
            Console.WriteLine("Enter Product Price :");
            int pprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Available Qty :");
            int pqty = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("Insert into Product values(@id,@desc,@price,@qty)", con);
            cmd.Parameters.AddWithValue("@id", pid);
            cmd.Parameters.AddWithValue("@desc", pdesc);
            cmd.Parameters.AddWithValue("@price", pprice);
            cmd.Parameters.AddWithValue("@qty", pqty);
            int result=cmd.ExecuteNonQuery();
            if(result>0)
            {
                Console.WriteLine("Added one record.");
            }
            else
                Console.WriteLine("Something went wrong.. did not insert");
        }
        public static void GetScalarFunc()
        {
            con = getCon();
            cmd = new SqlCommand("select count(Empid) from tblemployee", con);
            int empcount = Convert.ToInt32(cmd.ExecuteScalar()); // execute scalar returns object
            Console.WriteLine("No.of Employees :{0}",empcount);
        }
        public static void SelectEmployeeData()
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
