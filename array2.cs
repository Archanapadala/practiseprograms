//Single dimensional array(by using for , while , & for each loops)
namespace Practise
{
    internal class array2
    {
        
        static void Main(string[] args)
        {
            //int[] arr = new int[];    -  Error
            //int[] arr = new int[5];   -  Okay
            //int[] ar = new int[] {12,23,34,45,56 }; - Okay
            //int[] ar = { 12, 23, 34, 45 };  - Okay
            //int[] ar;   //Declaration
            //ar = {12,23,45 }; //Initlization
            //ar = new int[] { 1, 2, 3 }; 

            //Console.WriteLine(ar[0]);
            //Console.WriteLine(ar[1]);
            //Console.WriteLine(ar[2]);
            //Console.WriteLine(ar[3]);
            //Console.WriteLine(ar[4]);
            //Console.WriteLine(ar[5]);
            //Console.WriteLine(ar[6]);
            int[] ar = new int[] { 12, 3, 43, 11, 12, 5, 67, 98 };
            //for loop
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();

            //while loop
            int j = 0;
            while (j < ar.Length)
            {
                Console.Write(ar[j] + " ");
                j++;
            }
            Console.WriteLine();

            //foreach
            foreach (int i in ar)
            {
                Console.Write(i + " ");
            }
        }
    }

}

