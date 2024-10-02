//using OptiTourRoutesWebsite.Services;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using OptiTourRoutesWebsite.DB;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;

//var builder = WebApplication.CreateBuilder(args);


//// Đăng ký dịch vụ ITouristSpotService và TouristSpotService
////builder.Services.AddScoped<ITouristSpotService, TouristSpotService>();

//// Thêm các dịch vụ khác (như MVC)
//builder.Services.AddControllersWithViews();

//// Add services to the container.
//builder.Services.AddControllersWithViews();

////string path = Directory.GetCurrentDirectory();
////builder.Services.AddDbContext<TourDbContext>(options =>
////    options.UseSqlServer(
////      builder.Configuration.GetConnectionString("DefaultConnection")
////      .Replace("[DataDirectoty]", path))
////    );
//builder.Services.AddDbContext<TourDbContext>(options =>
//        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
