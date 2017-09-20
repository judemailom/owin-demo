using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinDemo.Models
{
    public class CourseModel
    {
        public CourseModel(string id, string title, string watchHref, string authorId, string length, string category) {
            this.id = id;
            this.title = title;
            this.watchHref = watchHref;
            this.authorId = authorId;
            this.length = length;
            this.category = category;
    }
        public string id { get; set; }
        public string title { get; set; }
        public string watchHref { get; set; }
        public string authorId { get; set; }
        public string length { get; set; }
        public string category { get; set; }
    }
}