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
