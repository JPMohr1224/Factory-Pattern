using System;
namespace FactoryPattern
{
	public class GrilledCheese : ISandwiches
    {
		public GrilledCheese()
		{
		}

        public string Description()
        {
            return "Melted cheese, crispy toasted sourdough";
        }
    }
}

