using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfterTenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday year: ");
            String birthday = Console.ReadLine();
            Console.Write("You are now ");
            int currentYear = DateTime.Now.Year;
            int currentAge = currentYear - Convert.ToInt32(birthday);
            Console.WriteLine(Convert.ToString(currentAge) + " years old.");
            Console.WriteLine("You will be " + Convert.ToString(currentAge + 10) + " in 10 years :)");
        }
    }
}
