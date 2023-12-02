namespace WebShop.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public string ImageURL { get; set; }
		public int Price { get; set; }
		public bool IsFavorite { get; set; }
		public int Amount { get; set; }
		public string Category { get; set; }

		public Item(string name, string shortDescription, string longDescription, string imageURL, int price, bool isFavorite, int amount, string category)
		{
			Name = name;
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			ImageURL = imageURL;
			Price = price;
			IsFavorite = isFavorite;
			Amount = amount;
			Category = category;
		}
	}
}
