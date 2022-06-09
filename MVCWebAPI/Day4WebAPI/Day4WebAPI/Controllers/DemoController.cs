using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Day4WebAPI.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> strings = new List<string> { "Data1", "Data2", "Data3", "Data4" };

        //GET :api/Demo
        public IEnumerable<string>Get()
        {
            return strings;
        }

        //GET : api/Demo/2
        public string Get(int id)
        {
            return strings[id];
        }

        //Post type 1
        public IEnumerable<string>Post([FromBody]string val)
        {
            strings.Add(val);
            return strings;
        }

        //PUT :api/Demo
        public IEnumerable<string>Put(int id,[FromUri] string val)
        {
            strings[id - 1] = val;
            return strings;
        }

        //DELET : api/DEmo

        public IEnumerable<string>Delete(int id)
        {
            strings.RemoveAt(id);
            return strings;
        }
    }
}
