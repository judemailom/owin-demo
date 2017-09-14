using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinDemo.Models
{
    public class CourseModel
    {
        public string id { get; set; }
        public string title { get; set; }
        public string watchHref { get; set; }
        public string authorId { get; set; }
        public string length { get; set; }
        public string category { get; set; }
    }
}