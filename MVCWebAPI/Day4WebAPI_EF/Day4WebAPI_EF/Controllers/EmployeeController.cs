using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Day4WebAPI_EF.Models;

namespace Day4WebAPI_EF.Controllers
{
    public class EmployeeController : ApiController
    {
        ZensarDBEntities db = new ZensarDBEntities();
        //Get
        //public HttpResponseMessage Get()
        //{
        //    var emp = db.tblEmployees.ToList();
        //    if (emp.Count > 0)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, emp);
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, "No Data Found");
        //    }
        //}

        //get employees by gender
        //[Route("Gender")]
        //public HttpResponseMessage Get(string Gender = "Male")
        //{
        //    switch (Gender.ToLower())
        //    {
        //        case "all":
        //            return Request.CreateResponse(HttpStatusCode.OK, db.tblEmployees.ToList());
        //        case "male":
        //            return Request.CreateResponse(HttpStatusCode.OK,
        //                db.tblEmployees.Where(e => e.Gender.ToLower() == "male").ToList());
        //        case "female":
        //            return Request.CreateResponse(HttpStatusCode.OK,
        //                db.tblEmployees.Where(e => e.Gender.ToLower() == "female").ToList());
        //        default:
        //            return Request.CreateResponse(HttpStatusCode.BadRequest,
        //                "Value for Gender must be either Male or Female");
        //    }
        //}

        public IEnumerable<Product>Get()
        {
            return db.Products.ToList();
        }

        //Post
        public IHttpActionResult PostNewEmployee([FromBody]Product p)
        {
            if (!ModelState.IsValid)
                return BadRequest("Validations Failed");
            db.Products.Add(new Product()
            {
                ProductId=p.ProductId,
                ProductName=p.ProductName,
                Price=p.Price,
                QtyAvailable=p.QtyAvailable,
            }) ;
            db.SaveChanges();
            return Ok();
        }

    }
}
