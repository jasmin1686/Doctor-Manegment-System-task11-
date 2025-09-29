using Doctor_Manegment_System_task11_.Data;
using Microsoft.EntityFrameworkCore;

namespace Doctor_Manegment_System_task11_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
               
                context.Database.ExecuteSqlRaw(@"
        DELETE FROM Appointments
        WHERE PatientId NOT IN (SELECT Id FROM Patients)
    ");

                context.SaveChanges();
            }

            var builder = WebApplication.CreateBuilder(args);

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
            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();

        }
    }
}
