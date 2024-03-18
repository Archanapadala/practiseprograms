//Convert type casting 


namespace Practise
{
    internal class program9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Empno");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Emplyee Name ");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter Emplyee Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter percentage increment");
            short increment = Convert.ToInt16(Console.ReadLine());

            int totalsalary = Convert.ToInt32((salary * increment / 100) + salary);
            Console.WriteLine("welcome " + EmpName + "and your total salary is " + totalsalary);
        }
    }
}
