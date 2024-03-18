//parse
namespace Practise
{
    internal class program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee I'd");
            string Employeeid = Console.ReadLine();
            Console.WriteLine("Enter Employee Name");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Percentage");
            int percentage = int.Parse(Console.ReadLine());
            double totalsalary = salary * percentage / 100; 
            Console.WriteLine("Welcome "+Name+ "Your total salary is "+ (totalsalary+salary));
        }
    }
}
    