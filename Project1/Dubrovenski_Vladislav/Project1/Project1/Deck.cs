using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Deck
    {
        private Card[] _deck = new Card[52];

        private int _topIndex = -1;

        public Deck()
        {
            int numberOfSuits = 4;
            int numberOfRanks = 15;
            int numberOfCards = 52;
            _topIndex++; 
            while (_topIndex < numberOfCards)
            {
                for (int suit = 0; suit < numberOfSuits; suit++)
                {
                    for (int rank = 2; rank < numberOfRanks; rank++)
                    {           
                        _deck[_topIndex++] = new Card(rank, (CardSuit)suit);
                    }
                }
            }
            _topIndex--;
        }

        public Card Draw()
        {            
            Card c = _deck[_topIndex];
            _deck[_topIndex] = null;
            _topIndex--;
            return c;
        }

        /// <summary>
        /// Shuffle algorithm taken from Knuth
        /// </summary>
        public void Shuffle()
        {
            System.Random random = new System.Random();
            for (int i = 0; i < _deck.Length; i++)
            {
                int j = random.Next(i, _deck.Length); // Don't select from the entire array on subsequent loops
                Card temp = _deck[i];
                _deck[i] = _deck[j];
                _deck[j] = temp;
            }
        }

        /// <summary>
        /// return the card to the deck
        /// </summary>
        /// <param name="card"></param>
        public void ReturnCard(Card card)
        {
            _deck[++_topIndex] = card;
        }
    }
}
