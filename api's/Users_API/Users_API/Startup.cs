using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Users_API.Data;

namespace Users_API
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
<<<<<<< HEAD

=======
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
      services.AddControllers();

      services.AddSingleton<IConfiguration>(Configuration);

      services.AddCors();

      string connectionString = Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

      services.AddDbContext<UserContext>(options =>
                options.UseSqlServer(connectionString));

      services.AddMediatR(typeof(Startup).Assembly);

      services.AddControllers().AddNewtonsoftJson();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
<<<<<<< HEAD

=======
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

<<<<<<< HEAD
      app.UseCors(builder => builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

=======
>>>>>>> e8f90eb5f83bf7694033df1554170043a7fc9ebf
      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
