//swapping numbers
namespace Practise
{
    internal class case10
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"before swapping  x ={ x }  y = { y }");
            y = x + y;
            x = y - x;
            y = y - x;
            Console.WriteLine($"After swapping x={ y } y = { x }");
        }
    }
}
