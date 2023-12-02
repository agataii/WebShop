using WebShop.Models;

namespace WebShop.Services.Interfaces
{
	public interface IItemService
	{
		public IEnumerable<Item> AllItems { get; }
		public IEnumerable<Item> FavoriteItems { get; }
		public Item GetItemById(int id);
	}
}
