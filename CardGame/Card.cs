using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* Card class represents a playing card
*/

namespace CardGame
{
    class Card
    {
        public string face { get; private set; } // like Ace, king ..
        public string suit { get; private set; } // like hearts, clubs ..
        //constructor takes two parameters to initializes a card
        public Card(string face, string suit)
        {
            this.face = face;
            this.suit = suit;
        }
    
        // override tostring method for custom showing
        public override string ToString()
        {
            return face + " of " + suit;
        }

    }
}
