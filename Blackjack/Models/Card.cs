using System.Collections.Generic;
using System;
namespace Blackjack.Models
{
    public class Card
    {
        private string _suit; //Diamond, Heart, Spades, Clubs
        private int _type; //1-13 1(Ace) 11(Jack) 12(Queen) 13(King)
        private static List<Card> _deck = new List<Card>{};

        public Card(int suitIn, int typeIn)
        {
            if(suitIn == 1)
            {
                _suit = "diamonds";
            } else if(suitIn == 2)
            {
                _suit = "hearts";
            } else if(suitIn == 3)
            {
                _suit = "spades";
            } else if(suitIn == 4)
            {
                _suit = "clubs";
            } else
            {
                Console.WriteLine("Invalid suitIn");
            }
            _type = typeIn;
        }
        public void CreateDecks(int numberOfDecks)
        {
            for(var k = 1; k <= numberofDecks; k ++)
            {
                for(var i = 1; i <= 4; i ++)
                {
                    for(var j = 1; j <= 13; j ++){
                        Card newCard = new Card(i, j)
                        this.PushToList(newCard);
                    }
                }
            }
        }
        public List<Card> GetDeck()
        {
            return _deck;
        }

        public static void ClearDeck()
        {
            _deck.Clear();

        }
        public void PushToList()
        {
            _deck.Add(this);
        }
    }
}
