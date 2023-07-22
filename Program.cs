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

            decimal average = (Mathematics + Biology + Art + Chesmistry + Sciences)/5;
            Console.WriteLine("Average Grade: " + average);
            Console.WriteLine(new string('-', 40));
            
            if(average > 4 && average <=5 )
                Console.WriteLine("Yoe are an Exellent student");
                
            else if(average <= 4 && average > 3)
                Console.WriteLine("Yoe are a good student");

            else if(average > 0 && average <=3)
               Console.WriteLine("Yoe are a bad student");

            else
               Console.WriteLine("Invalid Input");
        }
    }
}
