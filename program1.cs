//example for write , writeline , read and readline
namespace Practise
{
    internal class program1
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Introduce yourself");
            Console.Write("Your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of places you visited");
            int places = Console.Read();  
        }
    }
}
