//do while 
namespace Practise
{
    internal class loop5
    {
        static void Main(string[] args)
        {
            int n = 4, i = 1, table;
            do
            {
               table = n * i;
                Console.WriteLine("{0} * {1} = {2}", n, i, table);
                i++;

            }
            while (i <= 10);
        }
    }
}
