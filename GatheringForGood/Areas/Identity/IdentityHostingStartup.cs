﻿using System;
using GatheringForGood.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GatheringForGood.Areas.Identity.IdentityHostingStartup))]
namespace GatheringForGood.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
//            });
        }
    }
}