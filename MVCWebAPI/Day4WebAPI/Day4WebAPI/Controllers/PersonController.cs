using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Day4WebAPI.Models;

namespace Day4WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{Id=1,Name="Lokesh",City="Bangalore"},
            new Person{Id=2,Name="Himakar",City="Hyderabad"},
           new Person{Id=3,Name="Venkat",City="Bangalore"},
           new Person{Id=4,Name="Subham",City="Pune"},
        };

        //Get
        [Route("persondetails")]
        public IEnumerable<Person>Get()
        {
            return personlist;
        }

        //Get with HttpResponse as a return Type
        [Route("PersonList")]
        public HttpResponseMessage GetPersonList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);
            return response;
        }

        //Get by id
        public IHttpActionResult GetPerson(int id)
        {
            Person p = personlist.Find(a => a.Id==id);
            return Ok(p);
        }

        //Edit : api/person/2
        public IEnumerable<Person>Put(int id,[FromBody]Person p)
        {
            personlist[id - 1] = p;
            return personlist;
        }

        //Delete api/person/2

        public IEnumerable<Person>Delete(int id)
        {
            personlist.RemoveAt(id-1);
            return personlist;
        }

        //Post for body
        //public HttpResponseMessage Post([FromBody]Person p)
        //{
        //    personlist.Add(p);
        //    HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK, personlist);
        //    return res;
        //}

        //Post from URI

        public IEnumerable<Person> Post([FromUri] int Id, string Name, String City)
        {
            Person p = new Person();
            p.Id = Id;
            p.Name = Name;
            p.City = City;
            personlist.Add(p);
            return personlist;
        }

    }
}
