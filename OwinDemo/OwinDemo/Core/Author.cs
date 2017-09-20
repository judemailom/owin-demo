using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OwinDemo.Models;

namespace OwinDemo.Core
{
    public class Author
    {
        public string GetAllAuthors() {

            var sample = new List<AuthorModel>();

            sample.Add(new AuthorModel("course-house", "Cory", "House"));
            sample.Add(new AuthorModel("scott-allen","Scott","Allen"));
            sample.Add(new AuthorModel("dan-wahlin","Dan","Wahlin"));
            sample.Add(new AuthorModel("jude-allen","Jude","Allen"));

            return Newtonsoft.Json.JsonConvert.SerializeObject(sample);
        }
    }
}