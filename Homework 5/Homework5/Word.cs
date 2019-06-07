/* Word.cs
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
    /// This class will need to store a word and its number of occurrences in several files 
    /// </summary>
    public class Word
    {
        /// <summary>
        /// Stores a word.
        /// </summary>
        private string _word;
        /// <summary>
        /// Storing the number of occurrences of the word 
        /// </summary>
        private int[] _occurences;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="word">word to be processes</param>
        /// <param name="numberOfFiles">number of files</param>
        public Word(string word, int numberOfFiles)
        {
            _word = word;
            _occurences = new int[numberOfFiles];
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
        /// Gets the number of files
        /// </summary>
        public int NumberofFiles
        {
            get
            {
                return _occurences.Length;
            }
        }
        /// <summary>
        /// Gets the number of occurrences of the word in a specified file.
        /// </summary>
        /// <param name="fileNumber">The file number</param>
        /// <returns></returns>
        public int this[int fileNumber]
        {
                get
                {
                    if ( fileNumber >= _occurences.Length) 
                    {
                        throw new ArgumentException();
                    }

                return _occurences[fileNumber];
                }
        }
        /// <summary>
        ///  Takes a file number and increments the number of occurrences of the word in that file.
        /// </summary>
        /// <param name="fileNumber"> The file number</param>
        /// <returns></returns>
        public int Increment(int fileNumber)
        {
            if (fileNumber >= _occurences.Length)   
            {
                throw new ArgumentException();
            }

            return _occurences[fileNumber]++;
        }

    }
}
