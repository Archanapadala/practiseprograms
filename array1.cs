//array (single dimenssional array)
namespace Practise
{
    internal class array1
    {
        static void Main(string[] args)

        {
            int[] ar = new int[] { 12, 3, 43, 11, 12, 5, 67, 98 };

            for(int i=0; i<ar.Length; i++)
            {
                Console.WriteLine(ar[i] + "");
            }
            Console.WriteLine();
        }
    }
}
