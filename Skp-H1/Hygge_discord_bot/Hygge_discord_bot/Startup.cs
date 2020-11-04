﻿using Hygge_discord_bot.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hygge_discord_bot
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RPGContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RPGContext;Trusted_Connection=True;MultipleActiveResultSets=true",
                    x => x.MigrationsAssembly("Hygge_discord_bot.DAL.Migrations"));
            });

            var serviceprovider = services.BuildServiceProvider();

            var bot = new Bot(serviceprovider);
            services.AddSingleton(bot);
        }

        public void congigure(IApplicationBuilder app, IWebHostEnvironment env) { }

    }
}
