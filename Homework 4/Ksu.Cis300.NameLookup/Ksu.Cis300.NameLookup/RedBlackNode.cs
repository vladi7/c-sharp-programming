/* RedBlackNode.cs
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
using System.IO;
using Ksu.Cis300.ImmutableBinaryTrees;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.NameLookup
{
    public class RedBlackNode<T> : ITree, IColorizer
    {
        /// <summary>
        /// The data stored in this node.
        /// </summary>
        private T _data;

        /// <summary>
        /// Gets and sets the data stored in this node.
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
        /// This nodes parent.
        /// </summary>
        private RedBlackNode<T> _parent;

        /// <summary>
        /// Gets and sets this node's left child.
        /// </summary>
        public RedBlackNode<T> Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        /// <summary>
        /// This nodes left child.
        /// </summary>
        private RedBlackNode<T> _leftChild;

        /// <summary>
        /// Gets and sets this node's left child.
        /// </summary>
        public RedBlackNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
            set
            {
                _leftChild = value;
            }
        }

        /// <summary>
        /// This nodes right child.
        /// </summary>
        private RedBlackNode<T> _rightChild;

        /// <summary>
        /// Gets and sets this node's right child.
        /// </summary>
        public RedBlackNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
            set
            {
                _rightChild = value;
            }
        }

        /// <summary>
        /// Whether or not this node is colored black
        /// </summary>
        private bool _red;

        /// <summary>
        /// whether black or red
        /// </summary>
        public bool Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
            }
        }

        /// <summary>
        /// Gets and sets the children of this node.
        /// </summary>
        public ITree[] Children
        {
            get
            {
                ITree[] children = new ITree[2];
                children[0] = _leftChild;
                children[1] = _rightChild;
                return children;
            }
        }

        /// <summary>
        /// Gets whether this node is empty. Because empty trees will be represented by
        /// null, it always returns false.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the object to be drawn as the contents of this node.
        /// </summary>
        public object Root
        {
            get
            {
                return this;
            }
            
        }

        /// <summary>
        /// Constructs a RedBlackNode with the given data, left child, and right child.
        /// </summary>
        /// <param name="data">The data stored in the node.</param>
        /// <param name="left">The left child.</param>
        /// <param name="right">The right child.</param>
        /// <param name="parent">Parent.</param> 
        /// <param name="black">check if the node is black or not</param>
        public RedBlackNode(T data, RedBlackNode<T> left, RedBlackNode<T> right, RedBlackNode<T> parent, bool red)
        {
            _data = data;
            _leftChild = left;
            _rightChild = right;
            _parent = parent;
            _red = red;
        }

        public override string ToString()
        {
            return this._data.ToString();
        }

        /// <summary>
        /// implements the IColorizer interface
        /// </summary>
        /// <param name="obj"> object that is passed</param>
        /// <returns></returns>
        public Color GetColor(object obj)
        {
            RedBlackNode<T> node = (RedBlackNode<T>)obj;

            if (node.Red == false)
            {
                return Color.Black;
            }
            else
            {
                return Color.Red;
            }
        }

    }
}
