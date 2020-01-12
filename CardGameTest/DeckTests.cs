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
        List<Card> list;

        [TestInitialize]
        public void TestInitialize()
        {
            list = new List<Card>();
            list.Add(new Card((faceValues)(1), "Hearts"));
            list.Add(new Card((faceValues)(2), "Hearts"));
            list.Add(new Card((faceValues)(3), "Hearts"));
            list.Add(new Card((faceValues)(4), "Hearts"));
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
            Assert.AreNotEqual("Two of Hearts", d.pullOneCard(list));

        }

    }
}
