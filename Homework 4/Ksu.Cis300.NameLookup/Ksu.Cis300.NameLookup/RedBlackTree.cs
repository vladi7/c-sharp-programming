/* RedBlackTree.cs
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
    public class RedBlackTree<T> where T : IComparable<T>
    {
        /// <summary>
        /// node withe root
        /// </summary>
        RedBlackNode<T> _root = null;

        /// <summary>
        /// searches the tree starting at the root node for data that matches the parameter value
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public T Find(T val)
        {
            RedBlackNode<T> temp = _root;
            while (temp != null)
            {
                int comp = temp.Data.CompareTo(val);
                if (comp > 0)
                {
                    temp = temp.LeftChild;
                }
                else if (comp < 0)
                {
                    temp = temp.RightChild;
                }
                else
                {                 
                      return temp.Data;                 
                }
            }
            return default(T);
        }

        /// <summary>
        /// Rotates the tree right
        /// </summary>
        /// <param name="node">tree node</param>
        private void RotateRight(RedBlackNode<T> node)
        {
            RedBlackNode<T> newNode = node.LeftChild;
            node.LeftChild = newNode.RightChild;
            if (newNode.RightChild != null)
            {
                newNode.RightChild.Parent = node;
            }
            if (newNode != null)
            {
                newNode.Parent = node.Parent;
            }
            if (node.Parent == null)
            {
                _root = newNode;
            }                        
            else if (node == node.Parent.RightChild) 
            {
                node.Parent.RightChild = newNode;
            }
            else
            {
                node.Parent.LeftChild = newNode;
            }
            newNode.RightChild = node;
            if (node != null)
            {
                node.Parent = newNode;
            }          
        }

        /// <summary>
        /// Rotates the tree left
        /// </summary>
        /// <param name="node">tree node</param>
        private void RotateLeft(RedBlackNode<T> node)
        {
            RedBlackNode<T> newNode = node.RightChild;
            node.RightChild = newNode.LeftChild;
            if (newNode.LeftChild != null)
            {
                newNode.LeftChild.Parent = node;
            }
            if (newNode != null)
            {
                newNode.Parent = node.Parent;
            }
             if (node.Parent == null)
            {
                _root = newNode;
            }
            else if (node == node.Parent.LeftChild)
            {
                node.Parent.LeftChild = newNode;
            }
            else
            {
                node.Parent.RightChild = newNode;
            }
            newNode.LeftChild = node;
            if (node != null)
            {
                node.Parent = newNode;
            }          
        }

        /// <summary>
        /// recolors and rebalances the tree 
        /// </summary>
        /// <param name="lol"> newly added node</param>
        private void FixColors(RedBlackNode<T> node)
        {
            RedBlackNode<T> uncle = null;
            RedBlackNode<T> newNode = node;
            
                while (newNode != _root && newNode.Parent.Red && newNode.Red)
                {
                    if (newNode.Parent == newNode.Parent.Parent.LeftChild)
                    {
                        uncle = newNode.Parent.Parent.RightChild;
                    }
                    else if (newNode.Parent == newNode.Parent.Parent.RightChild)
                    {
                        uncle = newNode.Parent.Parent.LeftChild;
                    }
                    if (newNode.Parent.Parent.RightChild != null && newNode.Parent.Parent.LeftChild != null && uncle.Red)
                    {
                            if (uncle == newNode.Parent.Parent.RightChild)
                            {
                                newNode.Parent.Parent.Red = true;
                                newNode.Parent.Red = false;
                                newNode.Parent.Parent.RightChild.Red = false;                              
                            }
                            else
                            {
                                newNode.Parent.Parent.Red = true;
                                newNode.Parent.Red = false;
                                newNode.Parent.Parent.LeftChild.Red = false;                               
                            }
                            newNode = newNode.Parent.Parent;                       
                    }
                    else if (uncle == null || uncle.Red == false)
                    {
                        if (newNode == newNode.Parent.LeftChild && newNode.Parent == newNode.Parent.Parent.LeftChild)
                        {
                            RotateRight(newNode.Parent.Parent);
                            newNode.Red = true;
                            newNode.Parent.Red = false;
                            newNode.Parent.RightChild.Red = true;
                            if (newNode.Parent.RightChild.RightChild != null)
                                newNode.Parent.RightChild.RightChild.Red = false;
                        }
                        else if (newNode == newNode.Parent.RightChild && newNode.Parent == newNode.Parent.Parent.RightChild)
                        {
                            RotateLeft(newNode.Parent.Parent);//exception thrown
                            newNode.Red = true;
                            newNode.Parent.Red = false; 
                            newNode.Parent.LeftChild.Red = true; //true                          
                            if (newNode.Parent.LeftChild.LeftChild != null)
                                newNode.Parent.LeftChild.LeftChild.Red = false;                          
                        }
                        else if (newNode == newNode.Parent.RightChild && newNode.Parent == newNode.Parent.Parent.LeftChild) //???????
                        {                     
                            RotateLeft(newNode.Parent);
                            RotateRight(newNode.Parent);
                            newNode.Red = false;
                            newNode.LeftChild.Red = true;
                            newNode.RightChild.Red = true;
                            if (newNode.RightChild.RightChild != null)
                                newNode.RightChild.RightChild.Red = false;
                        }
                        else 
                        {                      
                            RotateRight(newNode.Parent);
                            RotateLeft(newNode.Parent);
                            newNode.Red = false;
                            newNode.RightChild.Red = true;
                            newNode.LeftChild.Red = true;                                                       
                            if (newNode.LeftChild.LeftChild != null)
                                newNode.LeftChild.LeftChild.Red = false;                            
                        }
                    }
                }         
             _root.Red = false;
        }

        /// <summary>
        /// Adds a new RedBlackNode in the correct location
        /// </summary>
        /// <param name="val">node that contains the data</param>
        public void Add(T val)
        {
            RedBlackNode<T> node = new RedBlackNode<T>(val, null, null, null, false);
            if (_root == null)
            {
                _root = node;
                return;
            }
            RedBlackNode<T> root = _root;
            RedBlackNode<T> newNode = null;

            while (root != null)
            {
                int comparison = val.CompareTo(root.Data);
                if (comparison > 0)
                {
                    if (root.RightChild == null)
                    {
                        newNode = new RedBlackNode<T>(val, null, null, root, true);//false or true?
                        root.RightChild = newNode;
                        FixColors(newNode);
                        break;
                    }
                    root = root.RightChild;
                }
                else
                {
                    if (root.LeftChild == null)
                    {
                        newNode = new RedBlackNode<T>(val, null, null, root, true);//false or true?
                        root.LeftChild = newNode;
                        FixColors(newNode);
                        break;
                    }
                    root = root.LeftChild;
                }
               }      
        }

        /// <summary>
        ///  displays this RedBlackTree
        /// </summary>
        public void DrawTree()
        {
            new TreeForm(_root, 100, _root).Show();
        }
    }
}
