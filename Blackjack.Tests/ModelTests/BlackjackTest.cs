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
        // [TestMethod, TestCategory("DeckShuffle")]
        // public void TestShuffle()
        // {
        //     int numberOfDecks = 10;
        //     Card.CreateDecks(numberOfDecks);
        //     List<Card> newDeck = Card.GetDeck();
        //     Card.randomShuffle();
        //     for(var i = 0; i < 52*numberOfDecks; i ++){
        //         Console.WriteLine(newDeck[i].printCard());
        //     }
        // }
            [TestMethod]
            public void TestPlayer()
            {
                Card tester = new Card(1,10);
                Player one = new Player("Alex");
                for(int i = 0; i < 13; i ++)
                {
                    tester = new Card(1, i);
                    one.PushToPlayer(tester);
                }
                Console.WriteLine(one.GetSum());

            }
        // [TestMethod, TestCategory("PlayerTest")]
        // public void TestShuffle()
        // {
        //     int numberOfDecks = 1;
        //     Card.CreateDecks(numberOfDecks);
        //     List<Card> newDeck = Card.GetDeck();
        //     Card.randomShuffle();
        //     Player one = new Player("Alex");
        //     Player two = new Player("Victor");
        //     for(int i = 0; i < 52*numberOfDecks; i ++)
        //     {
        //         Console.WriteLine(newDeck[i].printCard());
        //         if(i%2 == 0)
        //         {
        //             one.PushToPlayer(newDeck[i]);
        //         } else
        //         {
        //             two.PushToPlayer(newDeck[i]);
        //         }
        //     }
        //     List<Card> playerOneCards = one.GetPlayerCards();
        //     List<Card> playerTwoCards = two.GetPlayerCards();
        //     for(int j = 0; j < playerTwoCards.Count; j ++)
        //     {
        //         Console.WriteLine("Current Position for Player One: " + j + " Card " + playerOneCards[j].printCard());
        //         Console.WriteLine("Two Card " + playerTwoCards[j].printCard());
        //     }
        // }
        // [TestMethod, TestCategory("DistributionCheck")]
        // public void TestDistribution()
        // {
        //     int numberOfDecks = 1;
        //     for(var i = 0; i < 10; i ++)
        //     {
        //         Card.CreateDecks(numberOfDecks);
        //         List<Card> newDeck = Card.GetDeck();
        //         Card.randomShuffle();
        //         Card.saveDistribution();;
        //     }
        //     Card.normalizeCheck();
        //     List<int> currDistribution = Card.getDistribution();
        //     for(var i = 0; i < 52; i ++)
        //     {
        //         Console.WriteLine(currDistribution[i]);
        //     }
        // }
      }
}
