//nested loop (loop inside loop)
namespace Practise
{
    internal class loop6
    {
        static void Main(string[] args)
        {
            //outer loop 
            for (int i = 0; i <3 ; i++)
            {
                //inner loop
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{i}-{j}");
                }
            }
        }

    }
}
