using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

class MainClass
{

    private const double pricePerCustomer = 9.99;
    private const double pricePerCoffee = 2.00;

    public static void Main(string[] args)
    {
        {
            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra " +
                "for coffee. How many people are in your group? Please, parties of 6 or lower.");
            var numberOfCustomersAsString = Console.ReadLine();

            if (!int.TryParse(numberOfCustomersAsString, out var numberOfCustomers))
            {
                Console.WriteLine("Sorry that's an invalid input.");
                Environment.Exit(0);
            }

            if (numberOfCustomers > 6)
            {
                Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
                Environment.Exit(0);
            }


            Console.WriteLine($"A table for {numberOfCustomers}! Please follow me and take a seat.");
            Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");

            var totalBill = numberOfCustomers * pricePerCustomer;

            var waterCount = 0;
            var coffeeCount = 0;

            for (int i = 1; i <= numberOfCustomers; i++)
            {
                Console.WriteLine($"Alright, person number {i}, water or coffee?");
                var drinkOrder = Console.ReadLine();
                var drinkOrderLowerCase = drinkOrder.ToLower();


                if (drinkOrderLowerCase == "coffee")
                {
                    totalBill += pricePerCoffee;
                    coffeeCount += 1;
                    Console.WriteLine("Coffee, okay!");
                }

                else if (drinkOrderLowerCase == "water")
                {
                    Console.WriteLine("Water, good choice!");
                    waterCount += 1;
                }

                else
                {
                    Console.WriteLine("We don't have that. No drink for you!");
                }
            }

            Console.WriteLine($"Okay, so that's {coffeeCount} coffees and {waterCount} waters. " +
                $"I'll be right back. Feel free to grab your food!");

            Console.WriteLine($"Here's your bill! Total price: ${totalBill}");

        }
    }
}