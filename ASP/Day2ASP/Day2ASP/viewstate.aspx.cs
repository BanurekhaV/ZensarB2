using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2ASP
{
    public partial class viewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Store_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            ViewState["pwd"] = TextBox2.Text;
            TextBox1.Text = " ";
            TextBox2.Text = string.Empty;
        }

        protected void Load_Click(object sender, EventArgs e)
        {
            string uname = ViewState["name"].ToString();
            string pwd = ViewState["pwd"].ToString();
            Label3.Text = "your name is " + "  " + uname + "and your password is " + pwd;

           // Label3.Text text = "Your Name is : " + ViewState["name"].ToString() + " " + " and your password is :" + " " + ViewState["pwd"];
        }
    }
}