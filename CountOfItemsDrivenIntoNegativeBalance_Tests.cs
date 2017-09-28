using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pavilion.PCS.Engine.BusinessLogic.Tests.Helpers;
using FluentAssertions;
using Pavilion.PCS.Engine.BusinessLogic.BL_Helper_Classes;

namespace Pavilion.PCS.Engine.BusinessLogic.Tests
{
	[TestClass]
	// ReSharper disable once InconsistentNaming
	public class CountOfItemsDrivenIntoNegativeBalance_Tests
	{
		[TestMethod]
		public void GivenACartAndABalanceWhenQueriedTheCountOfItemsDrivenIntoNegativeBalanceReflectsTheCartAndTheBalance()
		{
			var sut = new BLShoppingCart();
			sut.AddSomeItems();

			sut.CountOfItemsDrivenIntoNegativeBalance(5.00M).Should().Be(2);
		}
	}
}
