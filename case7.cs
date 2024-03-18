//if else ladder (will create if else like a ladder)
namespace Practise
{
    internal class case7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any operand");
            char op = Convert.ToChar(Console.ReadLine());
            //// Declare a variable(result) to store the result of the operation
            int res = 0;
            if(op == '+')
            {
                res = num1 + num2;
            }
            else if (op == '-')
            {
                res= num1 - num2;
            }
            else if ( op == '*')
            {
                res = num1 * num2;
            }
            else if ( op == '/')
            {
                res = num1 / num2;
            }
            Console.WriteLine("The result is "+res);
        }
    }
}
