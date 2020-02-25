using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PruebaPizzeria.Aplication;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.InMemory;
using PruebaPizzeria.Infraestructura;

namespace PruebaPizzeria
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.Add(
                new ServiceDescriptor(typeof(IUserService), typeof(UserService), ServiceLifetime.Scoped)
            );

            services.Add(
               new ServiceDescriptor(typeof(IUserContext), typeof(EntidadContext), ServiceLifetime.Scoped)
            );

            services.AddDbContext<EntidadContext>(opt => opt.UseInMemoryDatabase());

            services.AddMvc().ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            
            /*
            services.AddDbContext<PizzeriaContext>(opt =>
               opt.UseSqlServer(Configuration.GetConnectionString("Pizzeria"))
            );*/
                      


            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
