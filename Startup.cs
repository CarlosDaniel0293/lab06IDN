using Microsoft.Entity FrameworkCore;
using MovieLeans.Data;

public void ConfigureServices (IServiceCollection services)
{
    services.AddDbContext<MovieLeansContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddControllersWithViews();
}