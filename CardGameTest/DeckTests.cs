using System;
using System.Collections.Generic;
using CardGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CardGameTest
{
    [TestClass]
    public class DeckTests
    {
        List<Card> list;

        [TestInitialize]
        public void TestInitialize()
        {
            list = new List<Card>();
            list.Add(new Card("Ace", "Hearts"));
            list.Add(new Card("2", "Hearts"));
            list.Add(new Card("3", "Hearts"));
            list.Add(new Card("4", "Hearts"));
        }

        [TestMethod]
        public void TestPullOneCard()
        {
            Deck d = new Deck();            
            Assert.AreEqual("Ace of Hearts", d.pullOneCard(list));
        }

        [TestMethod]
        public void TestMixCards()
        {
            Deck d = new Deck();
            d.mix(list);
            Assert.AreNotEqual("Ace of Hearts", d.pullOneCard(list));
        }

        [TestMethod]
        public void TestSortCards()
        {
            Deck d = new Deck();
            d.mix(list);
            Assert.AreNotEqual("Ace of Hearts", d.pullOneCard(list));
            d.sortCards(list);
            
        }

    }
}
