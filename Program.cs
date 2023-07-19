using System;
namespace Averagely
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine("The average Calculator");
           Console.Write("Mathematics grade: ");
           decimal Mathematics = Convert.ToDecimal(Console.ReadLine());

           Console.Write("Biology grade: ");
           decimal Biology = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Art grade: ");
            decimal Art = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Chesmistry grade: ");
            decimal Chesmistry = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sciences grade: ");
            decimal Sciences = Convert.ToDecimal(Console.ReadLine());

            decimal avg = (Mathematics + Biology + Art + Chesmistry + Sciences)/5;
            Console.WriteLine("Average Grade: " + avg);
        }
    }
}
