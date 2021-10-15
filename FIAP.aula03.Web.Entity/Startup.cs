using FIAP.aula03.Web.Entity.Persistencia;
using FIAP.aula03.Web.Entity.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.aula03.Web.Entity
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
            services.AddControllersWithViews();

            // configuração a injeção da dependencia do Context
            services.AddDbContext<FabricaContext>(
                op => op.UseSqlServer(Configuration.GetConnectionString("conexao")));

            // configurar a injeção de dependencia do Respository
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();

            services.AddScoped<IBeneficioRepository, BeneficioRepository>();

            services.AddScoped<IFuncBeneficioRepository, FuncBeneficioRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
