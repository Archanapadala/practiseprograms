//jagged array
namespace Practise
{
    internal class array4
    {
         
        static void Main(string[] args)
        {
            //Jagged Array
            int[][] arr = new int[3][];
            arr[0] = new int[3] { 12, 23, 45 };
            arr[1] = new int[2] { 12, 23 };
            arr[2] = new int[5] { 98, 87, 76, 65, 54 };

            Console.WriteLine("Elements of jaggaed array are: ");
            foreach (int[] ar in arr)
            {
                foreach (int item in ar)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }

}

