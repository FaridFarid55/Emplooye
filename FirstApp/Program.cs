// Ignore Spelling: App

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace FirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // check Environment IsDevelopment
            if (!app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseHsts();
            }
            //
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();



            app.MapControllerRoute(
                                 name: "default",
                                 pattern: "{Area:exists}/{Controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                                 name: "LandingPages",
                                 pattern: "{Area:exists}/{Controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                                 name: "admin",
                                 pattern: "{Controller=Employees}/{action=List}/{id?}");

            app.MapControllerRoute(
                                 name: "Farid",
                                 pattern: "{Controller=Employees}/{action=Create}/{id?}");

            app.Run();
        }
    }
}
