using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day4WebService_Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnMsg_Click(object sender, EventArgs e)
        {
            ZensarServices.MyWebservices1SoapClient client = new ZensarServices.MyWebservices1SoapClient();
            // Label1.Text = client.Message(Txtname.Text);
            string str = client.Message(Txtname.Text);
            Label1.Text = str;
        }

        protected void BtnSquare_Click(object sender, EventArgs e)
        {
            ZensarServices.MyWebservices1SoapClient client = new ZensarServices.MyWebservices1SoapClient();
            float result = client.FindSqaure(float.Parse(Txtnumber.Text));
            Label1.Text = result.ToString();
        }
    }
}