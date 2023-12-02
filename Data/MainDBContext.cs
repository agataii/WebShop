using Microsoft.EntityFrameworkCore;
using WebShop.Models;

namespace WebShop.Data
{
	public class MainDBContext : DbContext
	{
		public MainDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{

		}

		public DbSet<Item> Items { get; set; }
	}
}
