using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/**
 * Deck class represents a deck of the playing cards 
 */
namespace CardGame
{
    class Deck
    {
        private ArrayList deck; // Array list of the card objects
        private const int NUMBER_OF_CARDS = 52; 

        // constructor fills the deck
        public Deck()
        {
            string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new ArrayList(NUMBER_OF_CARDS); // create the list based on the cards number
            int count = 0;    // init counter to iterate the deck 
            while (count < NUMBER_OF_CARDS)
            {
                foreach (var suit in suits) // first outerloop that iterate the suits  
                {
                    foreach (var face in faces) // innerloop for iterating the faces for each suit
                    {
                        deck.Add(new Card(face, suit)); // create a new card and add it to the deck list
                        // test the output 
                        Console.Write(deck[count]+", ");
                        if ((count+1) % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                        count++; 
                    }
                }
                
            }
            
        }
        // Mix method to shuffle the cards
        public void mix()
        {

        }
    }
}
