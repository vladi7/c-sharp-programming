/* MinPriorityQueue.cs
 * Author: Rod Howell */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.Sort
{
    /// <summary>
    /// A generic min-priority queue.
    /// </summary>
    /// <typeparam name="TPriority">The type of the priorities.</typeparam>
    /// <typeparam name="TValue">The type of the elements.</typeparam>
    public class MinPriorityQueue<TPriority, TValue> where TPriority : IComparable<TPriority>
    {
        /// <summary>
        /// The min-heap storing the elements with their priorities.
        /// </summary>
        private LeftistTree<KeyValuePair<TPriority, TValue>> _elements = null;

        /// <summary>
        /// The number of elements in the MinPriorityQueue.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements in the MinPriorityQueue.
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }

        /// <summary>
        /// Gets the minimum priority in the MinPriorityQueue.
        /// </summary>
        public TPriority MininumPriority
        {
            get
            {
                if (_elements == null)
                {
                    throw new InvalidOperationException();
                }
                return _elements.Data.Key;
            }
        }

        /// <summary>
        /// Gets a drawing of the min-heap.
        /// </summary>
        public TreeForm HeapDrawing
        {
            get
            {
                return new TreeForm(_elements, 100);
            }
        }

        /// <summary>
        /// Merges the given min-heaps into one.
        /// </summary>
        /// <param name="h1">One min-heap.</param>
        /// <param name="h2">The other min-heap.</param>
        /// <returns></returns>
        private static LeftistTree<KeyValuePair<TPriority, TValue>> Merge(LeftistTree<KeyValuePair<TPriority, TValue>> h1, 
            LeftistTree<KeyValuePair<TPriority, TValue>> h2)
        {
            if (h1 == null)
            {
                return h2;
            }
            else if (h2 == null)
            {
                return h1;
            }
            else
            {
                LeftistTree<KeyValuePair<TPriority, TValue>> smaller = h1;
                LeftistTree<KeyValuePair<TPriority, TValue>> larger = h2;
                if (h2.Data.Key.CompareTo(h1.Data.Key) < 0)
                {
                    smaller = h2;
                    larger = h1;
                }
                return new LeftistTree<KeyValuePair<TPriority, TValue>>(smaller.Data, smaller.LeftChild, Merge(smaller.RightChild, larger));
            }
        }

        /// <summary>
        /// Adds the given element with the given priority.
        /// </summary>
        /// <param name="x">The element to add.</param>
        /// <param name="p">The priority of the element.</param>
        public void Add(TValue x, TPriority p)
        {
            LeftistTree<KeyValuePair<TPriority, TValue>> node = 
                new LeftistTree<KeyValuePair<TPriority, TValue>>(new KeyValuePair<TPriority, TValue>(p, x), null, null);
            _elements = Merge(_elements, node);
            _count++;
        }

        /// <summary>
        /// Removes an element with minimum priority.
        /// </summary>
        /// <returns>The element removed.</returns>
        public TValue RemoveMinimumPriority()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException();
            }
            TValue x = _elements.Data.Value;
            _elements = Merge(_elements.LeftChild, _elements.RightChild);
            _count--;
            return x;
        }
    }
}
