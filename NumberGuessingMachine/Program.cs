using System;

namespace NumberGuessingMachine
{
    internal class Program
    {
        private static void Main(string[] args)
        {   //Console asks player for their name
            Console.Write("Hello, My name is Sanches! What's your name?" + "\n");
            string Name = Console.ReadLine();

            Console.Write("Hi " + Name + ", I'm thinking of a number between 1 and 10. Guess a number between 1 and 10!\n");
            Random rd = new Random { };
            //for (int i = 0; i < 10; i++)
            //{
            //int ComputersNumber = rd.Next(0, 11);
            //Console.Write(ComputersNumber + "\n");
            //}
            // Assign a random number to be the computers guess
            int ComputersNumber = rd.Next(0, 11);
            bool Play = true;
            while (Play)
            {
                // Get a number from user
                string Number = Console.ReadLine();
                int Result;
                if (int.TryParse(Number, out Result))
                {
                    if (Convert.ToInt32(Number) > ComputersNumber)
                    {   //console informs player that their guess was too high and tells them to guess again
                        Console.Write("Too High!" + "\n");
                        Console.Write("Guess again" + "\n");
                    }
                    else if (Convert.ToInt32(Number) < ComputersNumber)
                    {   //Console informs player that their guess was too low and tells them to guess again
                        Console.Write("Too Low!" + "\n");
                        Console.Write("Guess again" + "\n");
                    }
                    else
                    {   //Console informs player that they were correct
                        Console.Write("Bingo Bango Bongo, Bish Bash Bosh!" + "\n");
                        // end of the game.
                        Play = false;
                    }
                }
                else
                {
                    Console.Write("That wasn't a number, please write a number!" + "\n");
                }
            }
        }
    }
}