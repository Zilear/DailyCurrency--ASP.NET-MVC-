using BusinessObjects.Repository;
using BusinessObjects.Repository.Interfaces;
using JSONDeserializer;
using ServiceLibrary;
using ServiceLibrary.Interfaces;


FileLoader fileLoader = new FileLoader();
fileLoader.Load();
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IRootRepository, RootRepository>();
builder.Services.AddScoped<IRootService, RootService>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
