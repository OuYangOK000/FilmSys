using FilmSys.Models;
using FilmSys.Models.EF;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string connection = "Server=.;DataBase=DB_Cinema;Uid=sa;Pwd=sa;Encrypt=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<FilmDbContext>(options => options.UseSqlServer(connection));
builder.Services.AddTransient<IFilmRepository, EFFilmRepository>();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Film}/{action=Login}/{id?}");

app.Run();
