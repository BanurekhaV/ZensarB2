using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Day4Exceptions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/Employee.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            //}
            //catch(System.IO.FileNotFoundException fne)
            //{
            //    //log eeh exception into audit files or database etc
            //    Label1.Text = "File Not Found ...";
            //}
            //catch(System.UnauthorizedAccessException uae)
            //{
            //    Label1.Text = "Access Denied";
            //}
            //catch(Exception e)
            //{
            //    Label1.Text = "Some unknown problem occured..";
            //}
        }

        //protected void Page_Error(object sender, EventArgs e)
        //{
        //     Exception ex = Server.GetLastError();
        //     Server.ClearError();
        //     Response.Redirect("Errors.aspx");
        //    //Response.Write(ex);
        //}
    }
}