// if else 
using System.ComponentModel.Design;

namespace Practise
{
    internal class case3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User id");
            string userid = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            if (userid == "admin" && password == "admin") 
            {
               //if the condition is true
                Console.WriteLine("Login sucessful");
            }
            else
            {
                //if the condition is false
                Console.WriteLine("invalid credentials");
            }
        }
    }
}
