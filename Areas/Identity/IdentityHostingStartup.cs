using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using netcoreproject.Areas.Identity.Data;

[assembly: HostingStartup(typeof(netcoreproject.Areas.Identity.IdentityHostingStartup))]
namespace netcoreproject.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<netcoreprojectIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("netcoreprojectIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<netcoreprojectIdentityDbContext>();
            });
        }
    }
}