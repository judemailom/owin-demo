using Owin;
using OwinDemo.Middleware;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Nancy.Owin;
using System.Web.Http;

namespace OwinDemo
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
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
                }
            });

            var configAPI = new HttpConfiguration();
            configAPI.MapHttpAttributeRoutes();
            app.UseWebApi(configAPI);

            app.UseNancy(config => {
                config.PassThroughWhenStatusCodesAre(Nancy.HttpStatusCode.NotFound);
            });

            app.Use(async(ctx, next) => {
                await ctx.Response.WriteAsync("Hello world!");
            });
        }
    }
}