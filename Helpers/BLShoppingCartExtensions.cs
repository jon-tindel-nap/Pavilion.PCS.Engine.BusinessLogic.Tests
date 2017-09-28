using System.Collections.Generic;
using Pavilion.PCS.Data;
using Pavilion.PCS.Engine.InterfaceLibrary;

namespace Pavilion.PCS.Engine.BusinessLogic.Tests.Helpers
{
	// ReSharper disable once InconsistentNaming
	public static class BLShoppingCartExtensions
	{
		public static void AddSomeItems(this BLShoppingCart cart)
		{
			var shoppingCartItems = new List<ShoppingCartItem>
			{
				new ShoppingCartItem(new Product {Fees = 0.05M, Price = 1.00M, TaxRate = 0.10M, ProductName = "a"}, 1, 1, 1), // 1.15
				new ShoppingCartItem(new Product {Fees = 0.00M, Price = 5.00M, TaxRate = 0.10M, ProductName = "b"}, 1, 2, 1), // 1.15 + 5.50 = 6.65
				new ShoppingCartItem(new Product {Fees = 0.00M, Price = 1.00M, TaxRate = 0.10M, ProductName = "c"}, 1, 3, 1), // 6.65 + 1.10 = 7.75
			};
			shoppingCartItems.ForEach(cart.AddProductById);
		}
	}
}
