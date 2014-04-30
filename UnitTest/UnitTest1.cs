using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			decimal result = Class1.CalcSalesTax(ProductType.Desk);
			Assert.AreEqual(123.11m, result);
		}
	}
}
