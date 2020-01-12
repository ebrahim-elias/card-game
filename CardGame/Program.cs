using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            mainOption();            
        }
        private static void welcomeMessage()
        {
            Console.WriteLine(" _____________________________________________\n " +
                    ">> Welcome to Simple card game\n" +
                    ">> Pick an option:\n" +
                    ">> (1) shuffle the cards\n" +
                    ">> (2) Pull one card\n" +
                    ">> (3) Sort the cards\n" +
                    ">> (4) Quit\n" +
                    ">> ");
        }
        private static void mainOption()
        {
            Deck d = new Deck();
            
            bool finish = false;   // for Quitting the game
            while (!finish)
            {
                welcomeMessage();
                string input = Console.ReadLine();
                switch (input)  // hanling the input value from user
                {
                    case "1":
                        d.mix(d.deck);
                        break;
                    case "2":
                        d.pullOneCard(d.deck);
                        break;
                    case "3":
                        d.sortCards(d.deck);
                        break;
                    case "4":
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

    }
}
