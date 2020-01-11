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
        private List<Card> deck; // Array list of the card objects
        private const int NUMBER_OF_CARDS = 52; 

        // constructor fills the deck
        public Deck()
        {
            string[] faces = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new List<Card>(NUMBER_OF_CARDS); // create the list based on the cards number
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
            Random randomNumber = new Random(); // generate a random number
            // swap current card with a random card
            for (int firstCard = 0; firstCard < deck.Count; firstCard++)
            {
                int secondCard = randomNumber.Next(deck.Count); // random index of another card
                var temp = deck[firstCard];
                deck[firstCard] = deck[secondCard];
                deck[secondCard] = temp;                
            }
        }
        // pull one card and show it in the screen
        public void pullOneCard()
        {
            int currentCard = 0; // Index of next card to be pulled 
            if (currentCard < deck.Count)
            {
                Console.WriteLine(deck[currentCard]);
                deck.RemoveAt(currentCard);
            }
            else Console.WriteLine("No Cards to drawn");
        }
        // sort the cards in the game according to suits and value 
        public void sortCards()
        {
            List<Card> al = new List<Card>();

             al = deck.GroupBy(s => s.suit)
                  .OrderBy(g => g.Count())
                  .SelectMany(g => g.OrderBy(c => c.face)).ToList();

            foreach (var item in al)
            {

                Console.WriteLine(item);
            }
        }
    }
}
