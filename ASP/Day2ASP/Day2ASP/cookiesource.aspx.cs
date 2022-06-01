using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2ASP
{
    public partial class cookiesource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Redirect_Click(object sender, EventArgs e)
        {
            //persistant cookie
            //HttpCookie hc = new HttpCookie("mycookie");
            //hc["d1"] = TextBox1.Text;
            //hc["d2"] = TextBox2.Text;
            //Response.Cookies.Add(hc);
            //hc.Expires = DateTime.Now.AddMinutes(5);
            //Response.Redirect("cookiedest.aspx");

            //non-persistant cookie
            Response.Cookies["d1"].Value = TextBox1.Text;
            Response.Cookies["d2"].Value = TextBox2.Text;
            Response.Redirect("cookiedest.aspx");
        }
    }
}