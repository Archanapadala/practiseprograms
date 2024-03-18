namespace Practise
{
    internal class program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of comic book your looking for");
            string comicbook = Console.ReadLine();
            Console.WriteLine("Range of price");
            string range = Console.ReadLine();
            Console.WriteLine("Edition");
            string edition = Console.ReadLine();
            Console.WriteLine("Will get back with availability of " +comicbook +range +edition);

        }
    }
}
