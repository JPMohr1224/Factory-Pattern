namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 2Sandwich place. Would you like a Club Sandwich or a Grilled Cheese?");
            var order = Console.ReadLine();

           ISandwiches sandwich = SandwichFactory.MakeSandwich(order);
            sandwich.Description(); 
        }
    }
}
