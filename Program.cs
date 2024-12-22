using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation_RangeValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string number;
            Console.WriteLine("Enter your age: ");
            number = Console.ReadLine();

            if ( int.TryParse(number,out int age) && age >= 18 && age <= 60)
            {
                Console.WriteLine("You are eligible to apply for the job.");
            }
            else
            {
                Console.WriteLine("You are not eligible to apply for the job.");
            }
            Console.ReadLine();
        }
    }
}
