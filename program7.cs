// explicit type casting with parse 
using System.Numerics;

namespace Practise
{
    internal class program7
    {
        static void Main(string[] args)
        {
            //used parse :: string to any data type and ref to ref value
            Console.WriteLine("enter product name");
            string productname = Console.ReadLine();
            Console.WriteLine("Enter product price");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            int quantity = int.Parse(Console.ReadLine()); 
            double totalcost = price * quantity;
            Console.WriteLine("product name is" + productname + " and cost is: " + totalcost);
        }
    }
}
