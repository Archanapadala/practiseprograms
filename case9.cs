  
namespace Practise
{
    internal class case9
    {
        static void Main(string[] args)
        {
            day:
            Console.WriteLine("Enter any day number 1-7 in a week");
            int dayNumber =   int.Parse(Console.ReadLine());
            string dayName;

            
            switch (dayNumber)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = ("Invalid day number.");
                    goto day;
            }

            Console.WriteLine($"The day corresponding to the number {dayNumber} is {dayName}.");
        }
    }
    
}
