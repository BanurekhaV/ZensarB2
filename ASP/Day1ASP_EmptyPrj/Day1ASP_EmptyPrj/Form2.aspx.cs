using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1ASP_EmptyPrj
{
    public partial class Form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load" + "<br/> <br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render Complete" + "<br/> <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Init" + "<br/> <br/>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page Pre Init" + "<br/> <br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page Pre load" + "<br/> <br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page Init Complete" + "<br/> <br/>");
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Page Render" + "<br/> <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render" + "<br/> <br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
           // Response.Write("Page Unload Sucessfull" + "<br/> <br/>");
        }
    }
}