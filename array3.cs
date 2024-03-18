//multi-dimensional array 
namespace Practise
{
    internal class array3
    {
        static void Main(string[] args)
        {
            int[,] scores = { { 23, 45, 67 }, { 90, 12, 34 } };
            Console.WriteLine("student scores:");

            for (int row=0; row<2;row++)
            {
                for (int col = 0; col < 3; col++)
                    Console.WriteLine(scores[row , col] + "");

            }
            Console.WriteLine();
        }
    }
}
