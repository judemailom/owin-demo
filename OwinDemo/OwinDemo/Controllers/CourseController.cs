using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace OwinDemo.Controllers
{
    [RoutePrefix("api")]
    public class CourseController : ApiController
    {
        [Route("course")]
        [HttpGet]
        public HttpResponseMessage GetCourses()
        {
            var courseDB = new Core.Course(); //replace with DB access
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, courseDB.GetAllCourses());
            return response;
        }
    }
}