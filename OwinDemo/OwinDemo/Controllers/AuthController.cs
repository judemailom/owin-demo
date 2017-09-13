using OwinDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace OwinDemo.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            var model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (model.UserName.Equals("test", StringComparison.OrdinalIgnoreCase) && model.Password == "test")
            {
                var identity = new ClaimsIdentity("ApplicationCookie");
                identity.AddClaims(new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,model.UserName),
                    new Claim(ClaimTypes.Name, model.UserName)
                });
                HttpContext.GetOwinContext().Authentication.SignIn(identity);
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return Redirect("/");
        }
    }
}