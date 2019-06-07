using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Entity/Control Class
    /// </summary>
    class Player
    {
        private Card[] _hand;

        private int _topIndex;

        Deck _deck;

        public int _score { get; private set; }

        public int _numWins { get; private set; }

        public Player(Deck deck)
        {
            _topIndex = -1;
            _hand = new Card[5];
            _deck = deck;
            _numWins = 0;
        }

        /// <summary>
        /// adds a card in hand and updates topIndex
        /// </summary>
        public void Deal(Card c)
        {
            _hand[++_topIndex] = c;
        }

        /// <summary>
        /// replace the card indexed by “index” in “hand” with a new card drawn from
        ///Deck; the old card in the hand is returned to deck
        /// </summary>
        /// <param name="index">index to switch the card</param>
        public void Swap(int index)
        {
            Card c = _hand[index];
            _hand[index] = _deck.Draw();
            _deck.ReturnCard(c);
        }

        /// <summary>
        ///  return all cards in hand to deck at once 
        /// </summary>
        public void ReturnAllCardsInHand()
        {
            for (int i = 0; i < _hand.Length; i++)
            {
                _deck.ReturnCard(_hand[i]);
            }
            _topIndex = -1;
        }

        /// <summary>
        /// calculate the score of the cards in hand and put the value in property Score       
        /// </summary>
        private void CalcScore()
        {
            int eyes = 0;
            int rankValue = 0;
            for (int i = 0; i < _hand.Length; i++)
            {
                eyes += _hand[i]._numEyes;
            }
            for (int j = 0; j < _hand.Length; j++)
            {
                rankValue += _hand[j]._rankValue;
            }
            _score = eyes * rankValue;
        }

        /// <summary>
        /// overrides  ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            CalcScore();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _hand.Length; i++)
            {
                sb.Append(_hand[i].ToString());
            }
            sb.Append("            Score = ");
            sb.Append(_score);
            string playerInfo = sb.ToString();
            return playerInfo;
        }

        /// <summary>
        /// Increments NumWins by 1
        /// </summary>
        public void Won()
        {
            _numWins++;
        }
    }
}
