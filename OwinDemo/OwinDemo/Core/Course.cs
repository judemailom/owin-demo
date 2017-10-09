using OwinDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinDemo.Core
{
    public class Course
    {
        public string GetAllCourses()
        {

            var sample = new List<CourseModel>();

            sample.Add(new CourseModel("react-flux-building-applications", "Building Applications in React and Flux", "http://www.pluralsight.com/courses/react-flux-building-applications", "cory-house", "5:08", "JavaScript"));
            sample.Add(new CourseModel(
                id: "clean-codes",
                title: "Clean Code: Writing Code for Humans",
                watchHref: "http://www.pluralsight.com/courses/writing-clean-code-humans",
                authorId: "cory-house",
                length: "3:10",
                category: "Software Practices"
              ));

            sample.Add(new CourseModel(
                id: "architecture",
                title: "Architecting Applications for the Real World",
                watchHref: "http://www.pluralsight.com/courses/architecting-applications-dotnet",
                authorId: "cory-house",
                length: "2:52",
                category: "Software Architecture"
              ));

            sample.Add(new CourseModel(
                id: "career-reboot-for-developer-mind",
                title: "Becoming an Outlier: Reprogramming the Developer Mind",
                watchHref: "http://www.pluralsight.com/courses/career-reboot-for-developer-mind",
                authorId: "cory-house",
                length: "2:30",
                category: "Career"
              ));

            sample.Add(new CourseModel(
                id: "web-components-shadow-dom",
                title: "Web Component Fundamentals",
                watchHref: "http://www.pluralsight.com/courses/web-components-shadow-dom",
                authorId: "cory-house",
                length: "5:10",
                category: "HTML5"
              ));

            return Newtonsoft.Json.JsonConvert.SerializeObject(sample);
        }
    }
}