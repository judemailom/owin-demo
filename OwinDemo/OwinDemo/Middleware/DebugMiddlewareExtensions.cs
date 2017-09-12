using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwinDemo.Middleware
{
    public static class DebugMiddlewareExtensions
    {
        public static void UseDebugMiddleware(this IAppBuilder app, DebugMiddlewareOptions options = null) {
            if (options == null)
                options = new DebugMiddlewareOptions();

            //app.Use(async (ctx, next) =>
            //{
            //    await ctx.Response.WriteAsync("Hello world!2");
            //});
            app.Use<DebugMiddleware>(options);
        }
    }
}