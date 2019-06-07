using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class TehiGame
    {
       private Deck _deck;
       private TehiConsole _tehiConsole;
       private Player _player;
       private Player _system;
       private int _numTies;
       private const string _indexString = "          1   2   3   4   5";

        public TehiGame()
        {
            _deck = new Deck();
            _tehiConsole = new TehiConsole();
            _player = new Player(_deck);
            _system = new Player(_deck);
            _numTies = 0;
        }

        /// <summary>
        /// shuffle the deck, and
        ///– repeat the following 5 times
        ///– draw a card from deck and deal it to user
        ///– draw a card from the deck and deal it to system
        /// </summary>
        private void Deal()
        {
            int numberOfCards = 5;
            _deck.Shuffle();   
            for(int i = 0; i < numberOfCards; i++)
            {
                _player.Deal(_deck.Draw());
                _system.Deal(_deck.Draw());
            }          
        }

        /// <summary>
        ///  returns all cards in user’s and system’s hands to deck.
        /// </summary>
        private void ReturnCards()
        {
            _player.ReturnAllCardsInHand();
            _system.ReturnAllCardsInHand();         
        }

        /// <summary>
        /// depending on who won, call user’s Won( ), system’s Won( ), or update
        ///numTies.Then, return string “User Won”, “System Won”, or “Tie”.
        /// </summary>
        /// <returns></returns>
        private string Judge()
        {
            string Message;
            if (_player._score < _system._score)
            {
                _system.Won();
                Message = "System Won";
            }
            else if (_player._score > _system._score)
            {
                _player.Won();
                Message = "Player Won";
            }
            else
            {
                _numTies++;
                Message = "Tie";
            }
            return Message;
                
        }

        /// <summary>
        /// Return a string showing how many times user won, system
        /// won, and the game ends in a tie
        /// </summary>
        private string GameStat()
        {
         return "User Won : " + _player._numWins + " " + " System Won : " + _system._numWins + " " + "  Ties : " + _numTies;
        }

        /// <summary>
        /// This contains the main logic that does the sequencing to execute the use-case(realization)
        /// </summary>
        public void Go()
        {
            int indexValue;
            do
            {
                Deal();
                _tehiConsole.PrintString("User   : " + _player.ToString());
                _tehiConsole.PrintString(_indexString);
                if ((indexValue = _tehiConsole.ReadIndex()) > 0)
                {
                    _player.Swap(indexValue-1);
                }
                _tehiConsole.PrintString("User   : " + _player.ToString());
                _tehiConsole.PrintString("System : " +  _system.ToString());
                _tehiConsole.PrintString(Judge());
                _tehiConsole.PrintString(GameStat());
                ReturnCards();
            } while (_tehiConsole.ReadYN() == 'Y');
        }

    }
}
