

using System;

namespace ComputerAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
                //ask the user to enter name
                Console.WriteLine("Enter your name: ");
                String name = Console.ReadLine();
                
                Console.WriteLine("Hello: " + name);
            //will ask the user to enter his/her grades
            Console.WriteLine("Enter five(5) grades seperated by new line: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());
            double grade5 = Convert.ToDouble(Console.ReadLine());

            //computations to get the average
            double sum = grade1 + grade2 + grade3 + grade4 + grade5;
            double average = sum / 5;
            double Rounded = Math.Round(average); //to get the round of the average
            
            //printing the outputs
            Console.WriteLine(name + "Your Average Grade is: " + average);
            Console.WriteLine("The Round off Average Grade is: " + (Rounded));
            Console.WriteLine("Press any key to end the program: ");
            char key = Convert.ToChar(Console.ReadLine());
            Console.ReadKey();

        }
    }
}