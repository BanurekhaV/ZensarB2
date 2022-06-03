using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Day4WebServices
{
    /// <summary>
    /// Summary description for MyWebservices1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebservices1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string Message(string str)
        {
            return str + "Welcome to Web Services";
        }

        public void TestMethod()
        {
            Console.WriteLine("HI!!");
            
        }
        [WebMethod]
        public float FindSqaure(float num)
        {
            return num * num;
        }
    }
}
