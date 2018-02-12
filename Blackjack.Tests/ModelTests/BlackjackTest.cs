using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blackjack.Models;
namespace Blackjack.Tests
{
    [TestClass]
    public class DeckGeneration
    {
        // [TestMethod, TestCategory("DeckGeneration")]
        // [Ignore]
        // public void TestGenerateDecks()
        // {
        //     int numberOfDecks = 1;
        //     Card.CreateDecks(numberOfDecks);
        //     List<Card> newDeck = Card.GetDeck();
        //     for(var i = 0; i < 52*numberOfDecks; i ++){
        //         Console.WriteLine(newDeck[i].printCard());
        //     }
        // }
        [TestMethod, TestCategory("DeckShuffle")]
        public void TestShuffle()
        {
            int numberOfDecks = 1;
            Card.CreateDecks(numberOfDecks);
            List<Card> newDeck = Card.GetDeck();
            Card.shuffleDeck();
            for(var i = 0; i < 52*numberOfDecks; i ++){
                Console.WriteLine(newDeck[i].printCard());
            }

        }
      }
}
