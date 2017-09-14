using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinDemo.Models
{
    public class AuthorModel
    {
        public AuthorModel(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}