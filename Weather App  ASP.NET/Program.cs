WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

WebApplication? app = builder.Build();

app.UseStaticFiles();
app.MapControllers();

app.Run();
