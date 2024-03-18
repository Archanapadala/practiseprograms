//nested if else (will write if else block inside another if else )
using System.ComponentModel.Design;

namespace Practise
{
    internal class case5
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter user id");
            string userid = Console.ReadLine();
            if (userid == "archanapadala")
            {
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (password == "dollars") 
                {
                    Console.WriteLine("login successfull");
                }
                else
                    {
                    Console.WriteLine("invalid password");
                    }
            }
            else
            {
                Console.WriteLine("Invalid user id");
            }
        }
    }
}
