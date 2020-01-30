using BelfastWeatherApi.ActionFilters;
using BelfastWeatherApi.HttpClient;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BelfastWeatherApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

     
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // I have also configured some cors settings in Azure - NOT ideal but I feel its ok for this example
            // and we are not risking any risky incoming request which can get at our data
            services.AddCors(); 
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0); ;
            services.Configure<IConfiguration>(Configuration); // Injection of config -  Pass configuration around - eg: if we choose to store app settings like in web.config
            services.AddTransient<IRestSharpHttpClient, RestSharpHttpClient>(); // Different instance for every request

            // Inject a filter to catch requests in the http pipeline before hitting the controllers - if the modelstate is bad then send back a 500
            // Same instance for the lifetime of the same request ( diff. for new requests )
            services.AddScoped<ValidationActionFilter>(); 


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
            app.UseCors();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "id_by_city",
                template: "api/{controller}/{action}/{cityname?}",
                defaults: new { controller = "WeatherForecast", action = "get" });

                routes.MapRoute(
               name: "id_by_woeid",
               template: "api/{controller}/{action}/{id?}",
               defaults: new { controller = "WeatherForecast", action = "get" });
            });
        }
    }
}
