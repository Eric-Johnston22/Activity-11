using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_11
{
    internal class Program
    {
        class Dice
        {
            private int sides;

            // Constructor
            public Dice(int sides)
            {
                this.sides = sides;
            }

            // Random number object
            public static Random rand = new Random();

            // Dice roll method
            public int rollDie(int sides)
            {
                return rand.Next(1, sides);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 4 and 20");

            // Flag for do-while loop
            bool loopFlag = true;


            do
            {
                string input = Console.ReadLine();

                // Input validation, assign input to int sides
                if (!int.TryParse(input, out int sides) || sides < 4 || sides > 20)
                {
                    Console.WriteLine("Please a vaild number");
                }

                else
                {
                    // Create 2 dice objects with same # of sides
                    Dice dice1 = new Dice(sides);
                    Dice dice2 = new Dice(sides);

                    // Hold die roll results
                    int roll1 = 0;
                    int roll2 = 0;

                    // Roll counter
                    int numRolls = 1;

                    do
                    {
                        roll1 = dice1.rollDie(sides);
                        roll2 = dice2.rollDie(sides);
                        Console.WriteLine("Roll #" + numRolls + " [Dice 1]: " + roll1 + " [Dice 2]: " + roll2);
                        Console.WriteLine("------------------------------------");
                        

                        numRolls++;

                    } while ((roll1 != 1) || (roll2 != 1));

                    Console.WriteLine("It took " + (numRolls - 1) + " rolls to get snake eyes");

                    // Stop loop
                    loopFlag = false;
                }
            } while (loopFlag);

            // Await key stroke before closing console.
            Console.ReadKey();        
        }
    }
}
