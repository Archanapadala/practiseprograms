// simple if 
namespace Practise
{
    internal class case2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cosmetic that your looking for ");
            string cosmetic = Console.ReadLine();
            Console.WriteLine("Price between ?");
            double price = Convert.ToDouble(Console.ReadLine());
            if (price <= 1000)
            {
                Console.WriteLine("Cosmetic product is available at the price that your looking");
            }
        }
    }
}
