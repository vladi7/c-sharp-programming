/* LinkedListCell.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ksu.Cis300.TravelingSalesperson
{
    /// <summary>
    /// A single cell of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the element stored in the cell.</typeparam>
    public class LinkedListCell<T>
    {
        /// <summary>
        /// The data item stored in the cell.
        /// </summary>
        private T _data;

        /// <summary>
        /// Gets or sets the data item stored in the cell.
        /// </summary>
        public T Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        /// <summary>
        /// The next cell in the list.
        /// </summary>
        private LinkedListCell<T> _next;

        /// <summary>
        /// Gets or sets the next cell in the list.
        /// </summary>
        public LinkedListCell<T> Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }
    }
}
