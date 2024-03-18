//switch case 
using System.Numerics;

namespace Practise
{
    internal class case8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
           Operator:
            Console.WriteLine("Enter operator");
            char op = Convert.ToChar(Console.ReadLine());
            int res = 0;
            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    goto Operator;
            }
            Console.WriteLine("The result is " + res);
        }
    }
}
