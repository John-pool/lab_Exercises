using System;

class apple_price
{
    static void Main()
    {
        //gives constant value price for the apple
        double price = 32.50;
        
        //asks the user to input how many apples he will purchase
        Console.Write("Enter the number of apples you want to purchase: ");
        int numberOfApples = int.Parse(Console.ReadLine());
        
        //calculation
        double totalPrice = numberOfApples * price;
        
        Console.WriteLine($"The total price of {numberOfApples} apples is {totalPrice:F2}.");

        //to convert the double into an integer
        int convertedPrice = (int)totalPrice;

        Console.WriteLine($"The value of the converted price is {convertedPrice}.");
    }
}
