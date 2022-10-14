﻿namespace diceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;    

            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("press eny key to toll the dice!");

                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player wins this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("This score is now - player : " + playerPoints + ". Enemy : " + enemyPoints + "." );
                Console.WriteLine();

            }

            if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You win! :) ");
            }
            else if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You Lose! :(");
            }
            else
            {
                Console.WriteLine("It`s a draw! :/ ");
            }
            Console.ReadLine();

        }
    }
}