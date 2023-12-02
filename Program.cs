using WebShop.Data;
using WebShop.Services.Interfaces;
using WebShop.Services.Mocks;
using Microsoft.EntityFrameworkCore;

namespace WebShop
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);


			builder.Configuration.AddJsonFile("dbsettings.json");

			builder.Services.AddDbContext<MainDBContext>(
				options => 
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
			);

			// Add services to the container.
			builder.Services.AddTransient<IItemService, MockItemService>();
			builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapRazorPages();

			app.Run();
		}
	}
}