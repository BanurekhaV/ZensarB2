using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Day3Caching
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-PU8R89M\\BRSQL;initial catalog=ZensarDB; " +
                "integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("Sp_GetProducts",con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            //let us associate the datasource to the gridview control
            GridView1.DataSource = ds;
            GridView1.DataBind();

            Label1.Text = "This Page is Cached " + " " + DateTime.Now.ToString();

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    GridView2.DataSource = SqlDataSource1;
        //  //  GridView2.DataBind();
        //}
    }
}