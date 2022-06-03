using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day4MasterPages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDate_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}