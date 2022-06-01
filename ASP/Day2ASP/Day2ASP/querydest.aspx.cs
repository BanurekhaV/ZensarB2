using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2ASP
{
    public partial class querydest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Retrieve_Click(object sender, EventArgs e)
        {
            //method1 and method 2 can use the below code
            //string temp;
            //temp = "Name:" + (Request.QueryString["Qs1"].ToString());
            //temp += "--Password:" + Request.QueryString["Qs2"].ToString();
            //Label1.Text = temp;

            //method 2
            Label1.Text = Request.QueryString["qs1"];
            Label2.Text = Request.QueryString["qs2"];
        }
    }
}