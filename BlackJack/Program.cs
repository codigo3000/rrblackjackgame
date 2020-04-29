using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Options to start the game
            Options();

            var selectOption = Console.ReadLine();

            while (selectOption.ToLower() != "0")
            {
                switch (selectOption.ToLower())
                {                    
                    case "1":
                        StartPlayGame();

                        break;
                    default:

                        break;
                }

                Options();
                selectOption = Console.ReadLine();
            }

        }

        // Method write the options.
        private static void Options()
        {
            Console.WriteLine("                                 ");
            Console.WriteLine("****** Black Jack Game **********");            
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Start the game");           
            Console.WriteLine("0. Exit...");
        }

        // Method that starts the game
        private static void StartPlayGame()
        {
            string playAgain = "y";
            Console.Write("");

            cards card = new cards();

            Console.Write("");

            int card1 = card.getCard();
            int card2 = card.getCard();
            int totalUserScoreCard = card.totalUserScoreSave(card1 + card2);

            Console.WriteLine("Your Cards: " + card1.ToString() + " " + card2.ToString() + " = " + totalUserScoreCard);

            card1 = card.getCard();
            card2 = card.getCard();

            int totalScoreComputer = card.totalComputerScoreSave(card1 + card2);

            Console.WriteLine("Computer Cards: " + card1.ToString() + " " + card2.ToString() + " = " + totalScoreComputer.ToString());

            while (playAgain == "y")
            {
                Console.Write("");
                Console.WriteLine("Do you want another card (y/n)? ");
                playAgain = Console.ReadLine();

                if (playAgain == "n")
                {
                    break;
                }

                int userCard = card.getCard();
                totalUserScoreCard = card.totalUserScoreSave(userCard);
                int totalListUserCard = card.totalListUserCard();


                Console.WriteLine("Hit: " + userCard.ToString() + " Your total is " + totalUserScoreCard);

                if (totalUserScoreCard > 21)
                {
                    break;
                }

                if (totalListUserCard == 17)
                {
                    break;
                }
                
            }

            while (totalScoreComputer <= 21)
            {
                int cardComputer = card.getCard();
                int totalListCumputerCard = card.totalListComputerCard();

                Console.WriteLine("The computer takes a card: " + cardComputer.ToString());

                totalScoreComputer = card.totalComputerScoreSave(cardComputer);

                Console.Write("");
                totalListCumputerCard = card.totalListComputerCard();

                if (totalListCumputerCard == 17)
                {
                    break;
                }

            }

            Console.WriteLine("Your Score: " + totalUserScoreCard);
            Console.Write("");
            Console.WriteLine("Computer Score: " + totalScoreComputer);
            Console.Write("");

            if (totalUserScoreCard <= 21 && totalScoreComputer > 21)
            {
                Console.WriteLine("Your Won!");
            }
            else 
                {
                if (totalUserScoreCard <= 21 && totalUserScoreCard > totalScoreComputer)
                {
                    Console.WriteLine("Your Won!");
                }
                else
                {
                    if (totalScoreComputer <= 21 && totalUserScoreCard > 21)
                    {
                        Console.WriteLine("Computer Won!");
                    }
                    else
                    {
                        if (totalScoreComputer <= 21 && totalScoreComputer > totalUserScoreCard)
                        {
                            Console.WriteLine("Computer Won!");
                        }
                    }
                }
            }
        }
    }
}
