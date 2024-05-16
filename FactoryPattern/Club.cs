using System;
namespace FactoryPattern
{
    public class ClubSandwich : ISandwiches
	{
		public ClubSandwich()
		{
		}

        public string Description()
        {
           return "Turkey, Ham, Bacon";
        }
    }
}

