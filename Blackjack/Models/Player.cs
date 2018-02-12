using System.Collections.Generic;
using System;
namespace Blackjack.Models
{
    public class Player
    {
        private string _name;
        private int _score;
        private List<Card> _currentCards = new List<Card>{};
        public Player(string nameIn)
        {
            _name = nameIn;
        }
        public int GetScore()
        {
            return _score;
        }

        public List<Card> GetPlayerCards()
        {
            return _currentCards;
        }

        public void ClearPlayerCards()
        {
            _currentCards.Clear();

        }
        public void PushToPlayer(Card inputCard)
        {
            _currentCards.Add(inputCard);
        }
        public int GetPlayerSum()
        {
            int sum = 0;
            int currentCardValue;
            for(var i = 0; i < _currentCards.Count; i ++)
            {
                currentCardValue = _currentCards[i].GetNumber();
                if(currentCardValue == 1)
                {
                    sum += 10;
                } else if(currentCardValue == 11)
                {
                    //Jack
                    sum += 10;
                }else if(currentCardValue == 12)
                {
                    //Queen
                    sum += 10;
                } else if(currentCardValue == 13)
                {
                    //King
                    sum += 10;
                } else
                {
                    break;
                }
                sum += currentCardValue;
            }
            return sum;
        }
    }
}
