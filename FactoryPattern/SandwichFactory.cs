using System;
namespace FactoryPattern
{
	public static class SandwichFactory
	{


		public static ISandwiches MakeSandwich(string order)
		{
			switch (order.ToLower())
			{
				case "club":
					return new ClubSandwich();
				case "grilled cheese":
					return new GrilledCheese();

				default: return new ClubSandwich();
			}

		}
	}
}
