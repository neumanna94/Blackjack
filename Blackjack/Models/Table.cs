using System.Collections.Generic;
using System;
namespace Blackjack.Models
{
    public class Table
    {
        private static List<Player> _playersPositions = new List<Player>{};
        private List<Card> _currentDeck = new List<Card>{};
        private int _currentPosition; //Position is 0-_playersPosition.Count
        //Generate the Deck
        public void PopulateDeck(int numberOfDecks)
        {
            _currentDeck = Card.CreateDecks(numberOfDecks);
            Card.ShuffleDeck();
        }

        //Want the list of all the players.
        public static List<Player> GetTable()
        {
            return _playersPositions;
        }

        public void ClearTable()
        {
            _playersPositions.Clear();

        }
        //Put a player in the next position.
        public void PushToTable(Player currentPlayer)
        {
            _playersPositions.Add(currentPlayer);
        }
        public void NextTurn()
        {
            _currentPosition ++;
              // Deal();
              // CheckHands();
              // _currentPosition = 0;
        }
        public void Deal()
        {
            _playersPositions[_currentPosition].PushToPlayer(_currentDeck[_currentDeck.Count - 1]);
            _currentDeck.RemoveAt(_currentDeck.Count - 1);
        }
        public string CheckForBust()
        {
            for(var i = 0; i < _playersPositions.Count; i ++)
            {
                Player currentPlayer = _playersPositions[i];
                if(currentPlayer.GetSum() > 21)
                {
                    return "bust";
                }
            }
            return null;
        }
        public List<Card> GetDeck()
        {
            return _currentDeck;
        }
    }
}
