﻿using System;
namespace Averagely
{
    class Program
    {
        static void Main()
        {
          bool isRepeat = false;

          do
          {
            Console.WriteLine("The average Calculator");
            Console.Write("Please enter quantity grades: ");
            string numbers = Console.ReadLine();
            int quantity = int.Parse(numbers);

            int countGrades = 0;
            for(int iteration = 1; iteration <= quantity; iteration++)
            {
               Console.Write($"{iteration}.Grade: ");
               countGrades+= int.Parse(Console.ReadLine());
            }
            
            decimal average = countGrades/quantity;
            Console.WriteLine("Average Grade: " + average);
            Console.WriteLine(new string('-', 40));

            if(average > 4 && average <=5 )
                 Console.WriteLine("Yoe are an Exellent student");

            else if(average <= 4 && average >= 3)
                 Console.WriteLine("Yoe are a good student");

            else if(average < 3  && average > 0)
                 Console.WriteLine("Yoe are a bad student");

            else 
                 Console.WriteLine("Invalid Input");

             Console.WriteLine();
             Console.Write("Do you want to Repeat? [y/n]: ");
             string answer = Console.ReadLine();

             isRepeat = answer == "y" ? true : false;                  
          }

          while(isRepeat);
        }
    }
}
