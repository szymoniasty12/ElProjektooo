using System;
using System.Collections.Generic;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up the game
            int playerScore = 0;
            int computerScore = 0;
            string playerChoice;
            int playagain = 0;
            Random rand = new Random();
            // lista możliwych wyborów do wylosowania 
            List<string> choices = new List<string> { "kamień", "papier", "nożyce" };
            Console.WriteLine("Gramy do trzech");
            // początek gry , założenie że gramy do trzech
            while (playagain == 0)
            {
                while (true)
                {
                   Console.WriteLine();
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Wybierz (kamień, papier, albo nożyce):");
                    playerChoice = Console.ReadLine().ToLower();

                    // ! = nie zawiera
                    if (!choices.Contains(playerChoice))
                    {
                        Console.WriteLine("nie ma takiej opcji");
                        continue;
                    }

                    // losowanie wyboru komputera ( z listy powyżej)
                    string computerChoice = choices[rand.Next(choices.Count)];
                 
                    Console.WriteLine($"Wybór komputera: {computerChoice}.");

                    //sprawdzenie kto wygrywa
                    if (playerChoice == "kamień" && computerChoice == "nożyce" ||
                        playerChoice == "papier" && computerChoice == "kamień" ||
                        playerChoice == "nożyce" && computerChoice == "piaper")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Wygrywasz!");
                        playerScore++;
                        Console.ResetColor();

                    }
                    else if (playerChoice == computerChoice)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("remis!");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("komputer wygrywa!");
                        computerScore++;
                        Console.ResetColor();

                    }

                    // pokaż wyniki
                    Console.WriteLine($"twój wynik: {playerScore} | wynik komputera: {computerScore}");
                   
                    if (playerScore == 3)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("wygrywasz cały pojedynek");
                        break;
                    }
                    else
                    {
                        if (computerScore == 3)
                        {
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("przegrywasz sieroto");
                            break;
                        }
                        
                    }
                }
               
                //ponowna gra
                Console.WriteLine("jeszcze raz? (t/n)");
                string playAgain2 = Console.ReadLine().ToLower();
                if (playAgain2 == "n")
                {
                    break;
                    
                }
                else
                {
                    playerScore = 0;
                    computerScore = 0;
                }
            }
            Console.WriteLine("dzięki za zagranie :)");
            Console.ReadKey();
        }
    }
}