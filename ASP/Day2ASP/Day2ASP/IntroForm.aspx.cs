using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2ASP
{
    public partial class IntroForm : System.Web.UI.Page
    {
        int clickscount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txt1.Text = "0";
            }
        }

        protected void Btn_Count_Click(object sender, EventArgs e)
        {
            //step 1
            // clickscount = clickscount + 1;
            //txt1.Text = clickscount.ToString();

            //step 2 using viewstate variable

            //if (ViewState["clicks"] != null)
            //{
            //    clickscount = (int)ViewState["clicks"] + 1;
            //}
            //txt1.Text = clickscount.ToString();

            //ViewState["clicks"] = clickscount;

            //step 3 using inbuilt viewstate variable that is attached to every server control(asp control)
            clickscount = Convert.ToInt32(txt1.Text) + 1;
            txt1.Text = clickscount.ToString();
        }
    }
}