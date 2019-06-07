/* Cell.cs
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
using Ksu.Cis300.Graphs;
using System.IO;
namespace Ksu.Cis300.Sudoku
{
    public class Cell
    {

        private int _row;
        private int _column;
        /// <summary>
        /// An int representing this cell's current value ("color") in the puzzle
        /// </summary>
        private int _color;
        /// <summary>
        /// A bool array representing the list of available values ("colors") for this cell.
        /// </summary>
        private bool[] _available = new bool[10];

        public Cell(int row, int column, int color)
        {
            _row = row;
            _column = column;
            _color = color;
        }
        /// <summary>
        ///  a property to get and to set this cell's current value
        /// </summary>
        public int Value
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        /// <summary>
        /// a property to get this cell's current row
        /// </summary>
        public int Row
        {
            get
            {
                return _row;
            }
        }

        /// <summary>
        /// a property to get this cell's current column
        /// </summary>
        public int Col
        {
            get
            {
                return _column;
            }
        }

        /// <summary>
        ///  a property to get this cell's bool array of available values
        /// </summary>
        public bool[] Moves
        {
            get
            {
                return _available;
            }
        }

        /// <summary>
        /// a method to add back index to the list of available values for this cell
        /// </summary>
        /// <param name="index">index</param>
        public void AddMove(int index)
        {
            _available[index] = false;
        }

        /// <summary>
        /// a method to remove index from the list of available values for this cell
        /// </summary>
        /// <param name="index">index</param>
        public void RemoveMove(int index)
        {           
            _available[index] = true;
        }
    }
}
