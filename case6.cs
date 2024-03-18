//nested if else example
namespace Practise
{
    internal class case6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select department");
            string department = Console.ReadLine();
            if (department == "Computer Science")
            {
                Console.WriteLine("Enter your percentage");
                int percentage = Convert .ToInt32(Console.ReadLine());
                if (percentage > 65)
                {
                    Console.WriteLine("Your  eligible");
                }
                else
                {
                    Console.WriteLine("Your not eligible");
                }
            }
            else
            {
                Console.WriteLine("We dont have that course");
            }
        }
    }
}
