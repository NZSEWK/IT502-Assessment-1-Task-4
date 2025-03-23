using System;

class Task4
{
    static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Welcome To GST Calculation Program");

        // Ask the user for product name
        Console.Write("Enter The Products Name: ");
        string productName = Console.ReadLine();

        // Ask the user for quantity
        Console.Write("Enter The Quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        // Ask the user for the price of one product
        Console.Write("Enter The Price of The Product : ");
        decimal productPrice = decimal.Parse(Console.ReadLine());

        // Ask the user if GST needs to be added or if it is included
        Console.WriteLine("1. GST Needs To Be Added To Price ");
        Console.WriteLine("2. GST Already Included In Price ");
        Console.Write("Please enter 1 or 2: ");
        int choice = int.Parse(Console.ReadLine());

        decimal totalPrice = 0;
        decimal gstAmount = 0;

        if (choice == 1) // If GST needs to be added
        {
            // GST is 15%
            gstAmount = productPrice * 0.15m;
            totalPrice = productPrice + gstAmount;

            // Show the prices
            Console.WriteLine("Price without GST: " + productPrice);
            Console.WriteLine("GST amount: " + gstAmount);
            Console.WriteLine("Price with GST: " + totalPrice);
        }
        else if (choice == 2) // If GST is not included
        {
            // Calculate GST amount if it's included in the price
            gstAmount = (productPrice * 3) / 23;
            decimal originalPrice = productPrice - gstAmount;
            totalPrice = productPrice;

            // Show the prices
            Console.WriteLine("Original price without GST: " + originalPrice);
            Console.WriteLine("GST amount included: " + gstAmount);
            Console.WriteLine("Total price including GST: " + totalPrice);
        }
        else
        {
            // If the user enters an invalid choice like 3
            Console.WriteLine("Invalid option selected.");
            return; // End the program
        }

        // Calculate the total price for the quantity added
        decimal totalCost = totalPrice * quantity;

        // Show the total price for the quantity
        Console.WriteLine("The total price for " + quantity + " items is: " + totalCost);
    }
}
