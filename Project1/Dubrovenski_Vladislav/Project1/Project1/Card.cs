using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Enumerator for suits of the cards
    /// </summary>
    public enum CardSuit { S, H, D, C }

    class Card
    {
      
        private CardSuit _suit;

        private int _rank;

        public int _rankValue { get; private set; }

        public int _numEyes { get; private set; }

        private string _toString;

        readonly string[] convertToString = { "S", "H", "D", "C" };

        public Card(int rank, CardSuit suit)
        {
         int rank2 = 2;
         int rank3 = 3;
         int rank4 = 4;
         int rank5 = 5;
         int rank6 = 6;
         int rank7 = 7;
         int rank8 = 8;
         int rank9 = 9;
         int rank10 = 10;
         int Jack = 11;
         int Queen = 12;
         int King = 13;
         int Ace = 14;
                
           _rank = rank;
           _suit = suit;

            if (_rank < Jack)///non-face cards
            {
                _numEyes = 0;
                if (rank == rank10)
                {
                    _toString = "T" + convertToString[(int)suit] + "  ";
                    _rankValue = 10;
                }
                else {
                    _toString = _rank + convertToString[(int)suit] + "  ";
                    if (_rank == rank2)
                    {
                        _rankValue = 2;
                    }
                    else if (_rank == rank3)
                    {
                        _rankValue = 3;
                    }
                    else if (_rank == rank4)
                    {
                        _rankValue = 4;
                    }
                    else if (_rank == rank5)
                    {
                        _rankValue = 5;
                    }
                    else if (_rank == rank6)
                    {
                        _rankValue = 6;
                    }
                    else if (_rank == rank7)
                    {
                        _rankValue = 7;
                    }
                    else if (_rank == rank8)
                    {
                        _rankValue = 8;
                    }
                    else if (_rank == rank9)
                    {
                        _rankValue = 9;
                    }
                }
            }
            else if (_rank > rank10) //face cards 
            {
                _rankValue = 0;

                if (_rank == Jack && _suit == CardSuit.H) // jack + hearts
                {
                    _numEyes = 1;
                    _toString = "J" + convertToString[(int)suit] + _numEyes + " ";
                }
                else if (_rank == Jack && _suit == CardSuit.S) // jack + spades
                {
                    _numEyes = 1;
                    _toString = "J" + convertToString[(int)suit] + _numEyes + " ";
                }
                else if (_rank == Jack) // jacks
                {
                    _numEyes = 2;
                    _toString = "J" + convertToString[(int)suit] + _numEyes + " ";
                }
                else if (_rank == King && _suit == CardSuit.D) //king + diamonds
                {
                    _numEyes = 1;
                    _toString = "K" + convertToString[(int)suit] + _numEyes + " ";
                }
                else if (_rank == Queen || _rank == King) // queens + kings
                {
                    _numEyes = 2;
                    if (_rank == Queen) { _toString = "Q" + convertToString[(int)suit] + _numEyes + " "; }
                    else if (_rank == King) { _toString = "K" + convertToString[(int)suit] + _numEyes + " "; }
                }
                else if (_rank == Ace)// Ace
                {
                    _rankValue = 1;
                    _toString = "A" + convertToString[(int)suit] + "  ";
                }
            }
        }    

        public override string ToString()
        {
            return _toString;       
        }
    }
}
