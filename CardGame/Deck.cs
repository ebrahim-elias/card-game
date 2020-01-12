using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame.Card;
/**
* Deck class represents a deck of the playing cards 
*/
namespace CardGame
{
    public class Deck
    {
        public List<Card> deck; // Array list of the card objects
        private const int NUMBER_OF_CARDS = 52; 

        // constructor fills the deck
        public Deck()
        {
            //string[] faces = { "Ace", "Two", "Three", "Four", "Five", "six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            deck = new List<Card>(NUMBER_OF_CARDS); // create the list based on the cards number
            int count = 0;    // counter to iterate the deck 
            while (count < NUMBER_OF_CARDS)
            {
                foreach (var suit in suits) // first outerloop that iterate the suits  
                {
                    foreach (faceValues face in Enum.GetValues(typeof(faceValues))) // innerloop for iterating the faces for each suit
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
        public void mix(List<Card> deck)
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
        public string pullOneCard(List<Card> deck)
        {
            try
            {
                int currentCard = 0; // Index of next card to be pulled 
                if (currentCard < deck.Count)
                {
                    var current = deck[currentCard];
                    Console.WriteLine(deck[currentCard]);
                    deck.RemoveAt(currentCard);
                    return current.ToString(); //returning the current Card
                }
                else Console.WriteLine("No more cards to draw");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
        // sort the cards in the game according to suits and value 
        public List<Card> sortCards(List<Card> deck)
        {
            try
            {
                List<Card> al = new List<Card>();
                // sorting the deck groupt by suits and orderd by faces
                al = deck.GroupBy(s => s.suit)
                     .OrderBy(g => g.Count())
                     .SelectMany(g => g.OrderBy(c => c.faceValue)).ToList();
                // for testing
                foreach (var item in al)
                {
                    Console.WriteLine(item);
                }
                return al;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            return null;

        }
    }
}
