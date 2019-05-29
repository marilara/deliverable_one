using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add encoding 

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Declare 3 number variables

            double number1;
            double number2;
            double number3;

            // Get 3 number inputs from user 

            Console.WriteLine("Welcome user!");
            Console.WriteLine("Enter your first dollar ($) amount.");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second dollar ($) amount.");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your third dollar ($) amount.");
            number3 = Convert.ToDouble(Console.ReadLine());

            // Create array with number inputs

            double[] numbers = new double[3] { number1, number2, number3 };

            // Print Average, Min, and Max

            Console.WriteLine("The Average: " + numbers.Average());
            Console.WriteLine("The Smallest amount: " + numbers.Min());
            Console.WriteLine("The Highest amount: " + numbers.Max());

            // Print total in US dollar, Swedish kroner, Japanese yen, and Thai baht

            Console.WriteLine("The total amount in US dollars is: " + numbers.Sum().ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("The total amount in Swedish kroner is: " + numbers.Sum().ToString("C", CultureInfo.CreateSpecificCulture("da-DK")));
            Console.WriteLine("The total amount in Japanese yen is: " + numbers.Sum().ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("The total amount in Thai baht is: " + numbers.Sum().ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

            Console.ReadKey();
        }
    }
}
