using System;
using System.Collections.Generic;
using CardGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CardGame.Card;

namespace CardGameTest
{
    [TestClass]
    public class DeckTests
    {
        List<Card> orderedList;
        List<Card> unorderedList;

        [TestInitialize]
        public void TestInitialize()
        {
            // a test list with only 4 items in it (1=Ace,2=Two,..)
            orderedList = new List<Card>();
            orderedList.Add(new Card((faceValues)(1), "Hearts"));
            orderedList.Add(new Card((faceValues)(2), "Hearts"));
            orderedList.Add(new Card((faceValues)(3), "Hearts"));
            orderedList.Add(new Card((faceValues)(4), "Hearts"));

            unorderedList = new List<Card>();
            unorderedList.Add(new Card((faceValues)(4), "Hearts"));
            unorderedList.Add(new Card((faceValues)(3), "Hearts"));
            unorderedList.Add(new Card((faceValues)(1), "Hearts"));
            unorderedList.Add(new Card((faceValues)(2), "Hearts"));
        }

        [TestMethod]
        public void TestPullOneCard()
        {
            Deck d = new Deck();    
            // the pullOneCard method must return the first card on the top wich is Ace of hearts
            // and then remove it from the deck
            Assert.AreEqual("Ace of Hearts", d.pullOneCard(orderedList));
        }

        [TestMethod]
        public void TestMixCards()
        {
            Deck d = new Deck();
            d.mix(orderedList);
            // the Mix Method shuffle the cards, its not necessary the Ace will drawn
            Assert.AreNotEqual("Ace of Hearts", d.pullOneCard(orderedList));
        }

        [TestMethod]
        public void TestSortCards()
        {
            Deck d = new Deck();
           
            // the first item in the unorderedList is Four of hearts
            Assert.AreEqual("Four of Hearts", d.pullOneCard(unorderedList));
            List<Card> newSortedList =  d.sortCards(unorderedList);
            // after sorting the deck agen it will came the first card in the list wich it will be Ace of hearts
            Assert.AreEqual("Ace of Hearts", d.pullOneCard(newSortedList));

        }

    }
}
