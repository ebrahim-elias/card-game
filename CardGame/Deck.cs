using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        private Card[] deck;
        private const int NUMBER_OF_CARDS = 52;

        public Deck()
        {
            string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new Card[NUMBER_OF_CARDS];
            int count = 0;
            while (count < NUMBER_OF_CARDS)
            {
                foreach (var suit in suits)
                {
                    foreach (var face in faces)
                    {
                        deck[count] = new Card(face, suit);
                        Console.WriteLine(deck[count]);
                        count++;
                    }
                }
                
            }
            
        }
    }
}
