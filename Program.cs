using System;
class frmStudentGradeProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Grades");
        Console.WriteLine("---------------------------------");
        Console.Write("English: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Math: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Science: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Filipino: ");
        double grade4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("History: ");
        double grade5 = Convert.ToDouble(Console.ReadLine());

        double sum = grade1 + grade2 + grade3 + grade4 + grade5;
        double average = sum / 5;
        
        
        if (average >= 75)
        {
            Console.WriteLine("The Student Passed");
            Console.WriteLine("The General average of " + name + " is " + average);
        }
        else
        {
            Console.WriteLine("The Student Failed");
            Console.WriteLine("The General average of " + name + " is " + average);
        }
    }
}