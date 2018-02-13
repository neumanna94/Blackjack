using System.Collections.Generic;
using System;
namespace Blackjack.Models
{
    public class Player
    {
        private string _name;
        private int _sum;
        private bool _hold;
        private List<Card> _currentCards = new List<Card>{};
        public Player(string nameIn)
        {
            _name = nameIn;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetSum()
        {
            CalculateSum();
            return _sum;
        }
        public void SetHold(bool settingTurn)
        {
            _hold = settingTurn;
        }
        public bool GetHold()
        {
            return _hold;
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
        public void CalculateSum()
        {
            for(int i = 0; i < _currentCards.Count; i ++)
            {
                _sum += _currentCards[i].GetNumber();
            }
        }
    }
}
