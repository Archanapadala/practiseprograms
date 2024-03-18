//for loop
namespace Practise
{
    internal class loop1
    {
        static void Main(string[] args)
        {
            int n = 5, sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                //sum=sum+i
                //sum=0+1=1
                //1+2=3
                //3+2=6
                //6+4=10
                //10+5=15
            }
            Console.WriteLine("the sum of natural numbers is " + sum);
        }
    }
}
