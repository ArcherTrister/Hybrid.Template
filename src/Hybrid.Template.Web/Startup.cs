// -----------------------------------------------------------------------
//  <copyright file="Startup.cs" company="Hybrid开源团队">
//      Copyright (c) 2014-2018 Hybrid. All rights reserved.
//  </copyright>
//  <site>https://www.lxking.cn</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:50</last-date>
// -----------------------------------------------------------------------

using Hybrid.Template.Web.Startups;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
#if NETCOREAPP3_0
using Microsoft.Extensions.Hosting;
#endif
using Microsoft.Extensions.Logging;

using Hybrid.AspNetCore;
using Hybrid.Core.Builders;
using Hybrid.Entity;


namespace Hybrid.Template.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHybrid<AspHybridPackManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
#if NETCOREAPP3_0
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)

#else
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)

#endif
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/#/500");
                app.UseHsts().UseHttpsRedirection();
            }

            app
                //.UseMiddleware<NodeNoFoundHandlerMiddleware>()
                .UseMiddleware<NodeExceptionHandlerMiddleware>()
                .UseDefaultFiles()
                .UseStaticFiles()
                .UseHybrid();
        }
    }
}