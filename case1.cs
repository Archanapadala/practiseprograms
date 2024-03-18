//case:1 Simple if (if condition is true , it executes)
namespace Practise
{
    internal class case1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your percentage");
            int percentage = Convert.ToInt16(Console.ReadLine());

            if (percentage >=39)
            {
                Console.WriteLine("You are qualified for the next class ");
            }
        }
    }
}
