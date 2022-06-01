using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2ASP
{
    public partial class cookiedest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Retrieve_Click(object sender, EventArgs e)
        {
            //retrieving a persistant cookie values
            //HttpCookie rc = Request.Cookies["mycookie"];
            //Label1.Text = rc["d1"];
            //Label2.Text = rc["d2"];

            //non=persistant cookie retrieval

            Label1.Text = Request.Cookies["d1"].Value.ToString();
            Label2.Text = Request.Cookies["d2"].Value.ToString();
        }
    }
}