/* WordStruct.cs
 * Author: Vladislav Dubrovenski 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ksu.Cis300.Sort;

namespace Homework5
{
    /// <summary>
    /// This class will need to store a word and its number of frequency
    /// </summary>
    public struct WordStruct
    {
        /// <summary>
        /// Stored the word
        /// </summary>
        private string _word;

        /// <summary>
        /// Stores the frequence of the word in each file
        /// </summary>
        private float[] _frequency;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="word">Stores a word.</param>
        /// <param name="numberOfWords">Number of word in each file</param>
        public WordStruct(Word word, int []numberOfWords)
        {
            _frequency = new float[numberOfWords.Length];
            _word = word.ToString();

            if (word.NumberofFiles != _frequency.Length)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < _frequency.Length; i++)
            {
               _frequency[i]=  word[i]/(float)numberOfWords[i];  
            }
        }
        /// <summary>
        /// Gets the word
        /// </summary>
        public string WordGet
            {
                get 
                {
                return _word;
                }
            }
        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="fileNumber">The file number that we get frequency from</param>
        /// <returns></returns>
        public float this[int fileNumber]
        {
            get
            {
                if (fileNumber >= _frequency.Length )   
                {
                    throw new ArgumentException();
                }

                return _frequency[fileNumber];
            }
        }
    }
}
