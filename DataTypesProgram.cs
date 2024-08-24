/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
namespace DataTypesApp {
  internal class program{
      
      
  static void Main() {
      
    Console.WriteLine("Enter the name of the item: ");
    string name = Console.ReadLine();
      
    Console.WriteLine("Enter the pieces of " + name );
    int pieces = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter the total price of " + name + "is: ");
    double price = Convert.ToDouble(Console.ReadLine());
    
    double sum = pieces * price;
    double exact = Math.Floor(price);
    
    Console.WriteLine("-------------------------------------------------");
    
    Console.WriteLine("The total price of the " + name + "is: " + sum );
    Console.WriteLine("The value of the original price is: " + price);
    Console.WriteLine("The value of the converted price is: " + exact);
    
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
  } 
  }
}