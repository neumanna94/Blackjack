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
        public List<Card> GetPlayersCards(int thisPlayer)
        {
            return _playersPositions[thisPlayer].GetPlayerCards();
        }
        public bool Hit(int thisPlayer)
        {
            Card topOfDeck = _currentDeck[_currentDeck.Count-1];
            _currentDeck.RemoveAt(_currentDeck.Count-1);
            _playersPositions[thisPlayer].PushToPlayer(topOfDeck);
            int currentSum = _playersPositions[thisPlayer].GetSum();
            //Busted
            if(currentSum > 21){
                return false;
            //Didn't bust
            } else {
                return true;
            }
        }
        //Can Refactor this one with FindTotal
        public Player findWinner()
        {
            Player currentMinPlayer = _playersPositions[0];
            Player currentPlayer;

            for(int i = 1 ; i <_playersPositions.Count; i ++)
            {
                currentPlayer = _playersPositions[i];
                if(!(Math.Abs(21-currentMinPlayer.GetSum()) < Math.Abs(21-currentPlayer.GetSum())))
                {
                    currentMinPlayer = currentPlayer;
                } else {

                }
            }
            return currentMinPlayer;
        }
        public int FindTotal(int thisPlayer)
        {
            int sum = _playersPositions[thisPlayer].GetSum();
            return sum;
        }
        public void ClearAllHands()
        {
            for(int i = 0; i <_playersPositions.Count; i ++)
            {
                _playersPositions[i].ClearPlayerCards();
            }
        }
        public void NewGame()
        {
            ClearTable();
            ClearAllHands();
        }
    }
}
