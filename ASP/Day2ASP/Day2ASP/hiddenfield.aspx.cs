using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day2ASP
{
    public partial class hiddenfield : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Store_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = TextBox1.Text;
            HiddenField2.Value = TextBox2.Text;
            TextBox1.Text = " ";
            TextBox2.Text = " ";
        }

        protected void Load_Click(object sender, EventArgs e)
        {
            Label3.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}