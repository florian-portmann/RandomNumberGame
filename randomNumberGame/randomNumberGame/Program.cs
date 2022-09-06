using System;
using System.Threading;

namespace randomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int highscore = 1000000000;
            do
            {
                Console.Clear();
                string text;
                int Attempts = 1;
                int trueNumber = new Random().Next(1, 100);
                Console.ForegroundColor = ConsoleColor.Blue;
                Program Text = new Program();

                Text.Write("Write a number between 1 and 100.\n"); 
                Console.ForegroundColor = ConsoleColor.White;
                
                    

                while (true)
                {
                    try
                    {
                        int Guess = Convert.ToInt32(Console.ReadLine());

                        if (Guess < 1 || Guess > 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Text.Write("Error, please write a number between 1 and 100\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }


                        else if (trueNumber > Guess)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Text.Write("The number is too small try again\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Attempts++;
                        }
                        else if (trueNumber < Guess)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Text.Write("The number is too big try again\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Attempts++;
                        }
                        else if (Guess == trueNumber)
                        {
                            break;
                        }
                        

                    }
                    catch
                    {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Text.Write("That's not a number, please type a NEW number\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        
                    }

                }


                Console.ForegroundColor = ConsoleColor.Green;
                Text.Write("Well done, you guessed the Number in " + Attempts + " attempts. \n");
                Console.ForegroundColor = ConsoleColor.White;

                if (Attempts < highscore)
                {
                highscore = Attempts;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Text.Write("New highscore: " + highscore + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Text.Write("the highscore is still: " + highscore + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Text.Write("Möchten Sie nochmals spielen? Wenn Ja, dann schreiben Sie retry.\n");
                Console.ForegroundColor = ConsoleColor.White;
            } while (Console.ReadLine() == "retry");
            Environment.Exit(1);


        }
        public void Write(string text)
        {
            char[] chars = text.ToCharArray();
            foreach (char item in chars)
            {
                Console.Write(item);
                Thread.Sleep(50);
            }
        }

    }
}

