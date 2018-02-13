using System.Collections.Generic;
using System;
namespace Blackjack.Models
{
    public class Table
    {
        private List<Player> _playersPositions = new List<Player>{};
        private List<Card> _currentDeck = new List<Card>{};
        private int _currentPosition; //Position is 0-_playersPosition.Count

        public void populateDeck(int numberOfDecks)
        {
            _currentDeck = Card.CreateDecks(numberOfDecks);
        }

        public List<Card> GetTable()
        {
            return _playersPositions;
        }

        public void ClearTable()
        {
            _playersPositions.Clear();

        }
        public void PushToTable(Player currentPlayer)
        {
            _playerPositions.Add(currentPlayer);
        }
        public void NextTurn()
        {
            if(_currentPosition == _playersPosition.Count)
            {
                Deal();
                CheckHands();
                _currentPosition = 0;
            } else
            {
                Deal();
                CheckHands();
            }
            _currentPosition ++;
        }
        public void Deal()
        {
            _playersPosition[_currentPosition].PushToPlayer(_currentDeck[_currentDeck.Count - 1]);
            _currentDeck.RemoveAt(_currentDeck.Count - 1);
        }
        public string CheckForBust()
        {
            for(var i = 0; i < _playersPositions.Count; i ++)
            {
                Player currentPlayer = _playersPosition[i];
                if(currentPlayer.GetSum() > 21)
                {
                    return "bust"
                }
            }
            return null;
        }


    }
}
