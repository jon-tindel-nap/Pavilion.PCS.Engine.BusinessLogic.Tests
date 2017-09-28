using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Pavilion.PCS.Engine.BusinessLogic.Tests.Helpers;

namespace Pavilion.PCS.Engine.BusinessLogic.Tests
{
	[TestClass]
	// ReSharper disable once InconsistentNaming
	public class RunningSubTotalPrices_Tests
	{
		[TestMethod]
		public void WhenItemsAreAddedToTheCartThenTheRunningSubTotalPricesReflectThoseItems()
		{
			var expected = new List<decimal> {1.15M, 6.65M, 7.75M};
			var sut = new BLShoppingCart();
			sut.AddSomeItems();

			sut.RunningSubTotalPrices().ShouldAllBeEquivalentTo(expected);
		}
	}
}
