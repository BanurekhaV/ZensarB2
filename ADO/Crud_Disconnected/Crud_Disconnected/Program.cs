using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Crud_Disconnected
{
    class Program
    {        
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            try
            {
                con = new SqlConnection("Data source=DESKTOP-PU8R89M\\BRSQL; initial catalog=Northwind;integrated security=true");
                con.Open();
                sda = new SqlDataAdapter("select * from Region", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "NorthwindRegion");
                DataTable dt = ds.Tables["NorthwindRegion"];

                //iterating the datatable rows and columns to fetch the data
                foreach (DataRow row in dt.Rows)
                {
                    foreach(DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col]);
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }

                //Adding one more table to the same dataset
                //Console.WriteLine("-----------------------");
                //sda = new SqlDataAdapter("Select * from Shippers", con);
                //sda.Fill(ds, "NorthwindShippers");
                //dt = ds.Tables["NorthwindShippers"];

                ////iterating the datatable rows and columns to fetch the data
                //foreach (DataRow row1 in dt.Rows)
                //{
                //    foreach (DataColumn col1 in dt.Columns)
                //    {
                //        Console.Write(row1[col1]);
                //        Console.Write("  ");
                //    }
                //    Console.WriteLine();
                //}

                sda = new SqlDataAdapter("Select * from [order details]where orderid between 10980 and 11000 order by unitprice desc", con);
                sda.Fill(ds, "NorthwindOrdDetails");
                dt = ds.Tables["NorthwindordDetails"];

                //iterating the datatable rows and columns to fetch the data
                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col1 in dt.Columns)
                    {
                        Console.Write(row1[col1]);
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }

            }
            catch (SqlException s)
            {
                Console.WriteLine(s.Message);
            }
            Console.Read();
        }
    }
}
