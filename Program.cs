using System;
namespace Averagely
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine("The average Calculator");
           Console.Write("Enter fist Number: ");
           decimal number1 = Convert.ToDecimal(Console.ReadLine());

           Console.Write("Enter second Number: ");
           decimal number2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter third Number: ");
           decimal number3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter fourth Number: ");
            decimal number4 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter fifth Number: ");
            decimal number5 = Convert.ToDecimal(Console.ReadLine());

            decimal avg = (number1 + number2 + number3 + number4 + number5)/5;
            Console.WriteLine("Average: " + avg);
        }
    }
}
