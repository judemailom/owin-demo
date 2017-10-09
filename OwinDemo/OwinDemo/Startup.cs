using Owin;
using OwinDemo.Middleware;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Nancy.Owin;
using System.Web.Http;
using OwinDemo.Core;
using SimpleInjector;

namespace OwinDemo
{
    public class Startup
    {
        static Container container;
        public static void Configuration(IAppBuilder app)
        {
            container = new Container();
            container.Register<IActionHandler,ClassActionHandler>();
            container.Verify();

            app.UseDebugMiddleware(new DebugMiddlewareOptions
            {
                OnIncomingRequest = (ctx) => {
                    var watch = new Stopwatch();
                    watch.Start();
                    ctx.Environment["DebugStopwatch"] = watch;
                },
                OnOutgoingRequest = (ctx) => {
                    var watch = (Stopwatch)ctx.Environment["DebugStopwatch"];
                    watch.Stop();
                    Debug.WriteLine("Request took:" + watch.ElapsedMilliseconds + " ms");
                    Debug.WriteLine(container.GetInstance<IActionHandler>().GetReAction("werw"));
                }
            });

            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new Microsoft.Owin.PathString("/Auth/Login")
            });

            app.Use(async (ctx, next) => {
                if (ctx.Authentication.User.Identity.IsAuthenticated)
                {
                    Debug.WriteLine("User: " + ctx.Authentication.User.Identity.Name);
                }
                else
                {
                    Debug.WriteLine("User not authenticated");
                }
                await next();
            });

            var configAPI = new HttpConfiguration();
            configAPI.MapHttpAttributeRoutes();
            app.UseWebApi(configAPI);

            app.Map("/nancy", mappedApp => { mappedApp.UseNancy(); });
            //app.UseNancy(config => {
            //    config.PassThroughWhenStatusCodesAre(Nancy.HttpStatusCode.NotFound);
            //});

            //app.Use(async(ctx, next) => {
            //    await ctx.Response.WriteAsync("Hello world!");
            //});
        }
    }
}