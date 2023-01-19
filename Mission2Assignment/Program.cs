using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
        class Dice_Game__Mission_2_Assignment_
        {
            // Function to simulate rolling of two dice
            static int RollDice()
            {
                Random rand = new Random();
                return rand.Next(1, 7) + rand.Next(1, 7);
            }

            // Function to print histogram of roll results
            static void PrintHistogram(int[] results, int totalRolls)
            {
                for (int i = 2; i <= 12; i++)
                {
                    double percentage = (results[i] / (double)totalRolls) * 100;
                    Console.Write(i + ": ");
                    for (int j = 0; j < percentage; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" " + percentage.ToString("F2") + "%");
                }
            }

            // Main program
            static void Main(string[] args)
            {
                Console.Write("Welcome to the dice throwing simulator!\n\n ");
                Console.Write("How many times would you like to roll the dice? ");
                int totalRolls = int.Parse(Console.ReadLine());
                int[] results = new int[13]; // initialize array to keep track of results
                for (int i = 0; i < totalRolls; i++)
                {
                    int rollResult = RollDice();
                    results[rollResult]++;
                }
            PrintHistogram(results, totalRolls);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            }
        }
}
