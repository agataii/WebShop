using WebShop.Models;
using WebShop.Services.Interfaces;

namespace WebShop.Services.Mocks
{
	public class MockItemService : IItemService
	{
		public IEnumerable<Item> AllItems => new List<Item>
		{
				new Item(
					"Черная футболка",
					"Черная футболка к. описание",
					"Черная футболка длинное описание",
					"/images/BlackTShirt.jpg",
					1000,
					false,
					100,
					"Футболки"),
				new Item(
					"Белая футболка",
					"Белая футболка к. описание",
					"Белая футболка длинное описание",
					"/images/WhiteTShirt.jpg",
					2000,
					false,
					200,
					"Футболки"),
				new Item(
					"Синяя футболка",
					"Синяя футболка к. описание",
					"Синяя футболка длинное описание",
					"/images/BlueTShirt.jpg",
					3000,
					false,
					300,
					"Футболки"),
				new Item(
					"Черные брюки",
					"Черные брюки к. описание",
					"Черные брюки длинное описание",
					"/images/BlackTrousers.jpg",
					2500,
					false,
					400,
					"Брюки"),
				new Item(
					"Белые брюки",
					"Белые брюки к. описание",
					"Белые брюки длинное описание",
					"/images/WhiteTrousers.jpg",
					1500,
					false,
					500,
					"Брюки"),
		};

		public IEnumerable<Item> FavoriteItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Item GetItemById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
