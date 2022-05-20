using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Connected
{
    class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
        DataAccess da = new DataAccess();
        private void GetRegion()
        {
            Console.WriteLine("Enter Region Id:");
            RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description :");
            RegionDescription = Console.ReadLine();
        }
        public void DisplayRegion()
        {
           da.DisplayRegion();
        }
        public void InsertRegion()
        {
            GetRegion();
            da.InsertRegion();
        }
        public void UpdateRegion()
        {
            da.UpdateRegion();
        }

        public void DeleteRegion()
        {
            da.DeleteRegion();
        }
    }
    class DataAccess
    {
        SqlConnection con=null;
        SqlCommand cmd=null;
        SqlDataReader dr;

        private SqlConnection GetConnection()
        {
            string connection = @"data source=DESKTOP-PU8R89M\BRSQL;Initial Catalog=Northwind;Integrated Security=true";
            con = new SqlConnection(connection);
            con.Open();
            return con;
        }

        public void DisplayRegion()
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand("select * from Region", con);
                dr=cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["RegionId"]+ " " + dr["RegionDescription"]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine("Some error Occured ..");
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertRegion()
        {

        }

        public void UpdateRegion()
        {

        }

        public void DeleteRegion()
        {

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
             Region region = new Region();
            try
            {
                region.DisplayRegion();
                region.InsertRegion();
                region.UpdateRegion();
                region.DeleteRegion();
                Console.Read();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
               
        }
    }
}
