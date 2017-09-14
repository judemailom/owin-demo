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
    public class AuthorController : ApiController
    {
        [Route("author")]
        [HttpGet]
        public HttpResponseMessage GetAuthors()
        {
            var authorDB = new Core.Author(); //replace with DB access
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, authorDB.GetAllAuthors());
            return response;
        }
    }
}