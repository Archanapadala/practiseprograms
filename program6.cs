//explicit type casting :: value to value & reference to refernce type 
namespace Practise
{
    internal class program6
    {
        static void Main(string[] args)
        {
            //explicit : high data type to low data type value & reference type to reference type 
            double p = 60.99;
            int q = (int)p;
            short r = (short)q;

            Console.WriteLine("Value p is " + p);
            Console.WriteLine("Value q is " + q);
            Console.WriteLine("Value r is " + r);
        }
    }
}
