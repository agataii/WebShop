using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShop.Services.Interfaces;

namespace WebShop.Pages
{
	public class ShopModel : PageModel
	{
		public IItemService ItemService { get; }

		public ShopModel(IItemService itemService)
		{
			ItemService = itemService;
		}

		public void OnGet()
		{
		}
	}
}
