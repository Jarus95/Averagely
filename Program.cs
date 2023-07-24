using System;
namespace Averagely
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The average Calculator");
            Console.Write("Mathematics grade: ");

            decimal mathematics = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Biology grade: ");
            decimal biology = Convert.ToDecimal(Console.ReadLine());
         

            Console.Write("Art grade: ");
            decimal art = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Chesmistry grade: ");
            decimal chesmistry = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Sciences grade: ");
            decimal sciences = Convert.ToDecimal(Console.ReadLine());

            decimal average = (mathematics + biology + art + chesmistry + sciences)/5;

            Console.WriteLine("Average Grade: " + average);
        }
    }
}
