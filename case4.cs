//
namespace Practise
{
    internal class case4
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the Number");
           int  number=Convert.ToInt32( Console.ReadLine());
            if (number < 15)
            {
                Console.WriteLine(+number+ "is less than 15");
            }
            else
            {
                Console.WriteLine(+number +"is greater than 15");
            }
        }
    }
}
