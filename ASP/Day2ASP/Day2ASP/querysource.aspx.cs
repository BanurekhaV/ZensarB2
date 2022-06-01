using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2ASP
{
    public partial class querysource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Redirect_Click(object sender, EventArgs e)
        {
            string url;
            //first method of sending the querystring values to destination
            // url = "querydest.aspx?Qs1=" + TextBox1.Text;            
            //url += "&Qs2=" + TextBox2.Text;
            // Response.Redirect(url);

            //second method of sending the querystring values to destination

            Response.Redirect("querydest.aspx?qs1=" + TextBox1.Text + "&qs2=" + TextBox2.Text);
        }
    }
}