using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
	public enum ProductType
	{
 		TV,
		Desk,
		Monitor,
		Keyboard
	}

	public class Class1
	{
		public static decimal CalcSalesTax(ProductType productType)
		{
			switch (productType)
			{
				case ProductType.TV:
					return 100 * 1.1m;
				case ProductType.Desk:
					return 120 * 1.2m;
				case ProductType.Monitor:
					return 170 * 1.5m;
				case ProductType.Keyboard:
					return 160 * 1.01m;
				default:
					return 0;
			}

		}
	}
}
