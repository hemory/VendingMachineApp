using System;
using System.Collections.Generic;

namespace LiveCodeSpot
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyMade = 0;


            Console.WriteLine("Welcome to the vending machine app.");

            Dictionary<int, string> selectionDictionary = new Dictionary<int, string>
            {
                {1,"A1" },
                {2,"A2" },
                {3,"A3" },
                {4,"B1" },
                {5,"B2" },
                {6,"B3" },
                {7,"C1" },
                {8,"C2" },
                {9,"C3" }
            };

            Dictionary<string, int> stock = new Dictionary<string, int>
            {
                {"A1", 0 },
                {"A2", 5 },
                {"A3", 5 },
                {"B1", 5 },
                {"B2", 5 },
                {"B3", 5 },
                {"C1", 5 },
                {"C2", 5 },
                {"C3", 5 }
            };

            Dictionary<string, string> merchandise = new Dictionary<string, string>
            {
                {"A1", "Snickers" },
                {"A2", "Skittles" },
                {"A3", "Ho-Hos" },
                {"B1", "Cheetos" },
                {"B2", "Gum" },
                {"B3", "Rap Snacks" },
                {"C1", "Ice Cream" },
                {"C2", "Now and Laters" },
                {"C3", "Chico Stick" }
            };

            Dictionary<string, double> prices = new Dictionary<string, double>
            {
                {"A1", 1.25 },
                {"A2", 1.75 },
                {"A3", 2.00 },
                {"B1", .75 },
                {"B2", .25 },
                {"B3", 1.25 },
                {"C1", 1.75 },
                {"C2", .50 },
                {"C3", .25 }
            };


            while (true)
            {


                Console.WriteLine("Please select from the following vending items.");
                Console.WriteLine();

                int counter = 0;
                int selectorCounter = 1;
                foreach (var item in merchandise.Values)
                {

                    Console.Write($"({selectionDictionary[selectorCounter]}):{item} | ");
                    selectorCounter++;


                    //Creates a new line for each of the rows the vending machine
                    counter++;

                    if (counter == 3)
                    {
                        Console.WriteLine();
                        counter = 0;
                    }

                }

                //take user selection
                string userEntry = Console.ReadLine().ToUpper();

                if (stock[userEntry] == 0)
                {
                    Console.WriteLine("We are all out of items. Sorry, please make another choice");
                    continue;
                }


                Console.WriteLine($"You chose {userEntry}. There are {stock[userEntry]} left in stock and the price is {prices[userEntry]}");

                Console.WriteLine("Would you like to proceed with your choice? y or n");
                string keepGoing = Console.ReadLine().ToLower();

                if (keepGoing == "n")
                {
                    break;
                }



                //TODO Logic for taking payment should go here


                stock[userEntry]--;


                Console.WriteLine("Now vending....");



                foreach (var item in stock)
                {
                    Console.WriteLine($"The current stock of {item.Key} is {item.Value}");
                }



                Console.WriteLine("Would you like to vend another item. y or n?");
                keepGoing = Console.ReadLine().ToLower();



                if (keepGoing == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }


            }

            Console.WriteLine("Thanks for vending with us!");


            Console.ReadLine();



        }

    }
}



















