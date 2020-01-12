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
    public class Card
    {
        //public string face { get; private set; } 
        public string suit { get; private set; } // like hearts, clubs ..

        public faceValues faceValue { get; private set; } // getting the enum face values

        //constructor takes two parameters to initializes a card
        public Card(faceValues face, string suit)
        {
            this.faceValue = face;
            this.suit = suit;
        }
    
        // override tostring method for custom showing
        public override string ToString()
        {
            return faceValue + " of " + suit;
        }
        // enum for the faces
        public enum faceValues
        {
            Ace = 1,
            Two = 2 ,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }
    }
}
