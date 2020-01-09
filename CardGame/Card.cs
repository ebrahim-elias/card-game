using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
