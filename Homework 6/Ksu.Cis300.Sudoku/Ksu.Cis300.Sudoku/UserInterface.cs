/* UserInterface.cs
 * Author: Vladislav Dubrovenski
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ksu.Cis300.Graphs;
using System.IO;
namespace Ksu.Cis300.Sudoku
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The size of the Sudoku puzzle
        /// </summary>
        private int _gridSize = 9;

        /// <summary>
        /// The size of a cell on the Sudoku grid
        /// </summary>
        private const int _cellSize = 40;

        /// <summary>
        ///  nodes are instances of the class representing a cell, and edges are ints.
        /// </summary>
        private DirectedGraph<Cell, int> _graph = null;

        /// <summary>
        /// A two-dimensional array of instances of the class representing a cell.
        /// </summary>
        private Cell[,] _cellsArray = new Cell[9, 9];
                
        /// <summary>
        /// Constructs the GUI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();

            for (int i = 0; i < _gridSize; i++)
            {
                DataGridViewTextBoxColumn txCol = new DataGridViewTextBoxColumn();
                txCol.MaxInputLength = 1;
                uxGrid.Columns.Add(txCol);
                uxGrid.Columns[i].Name = "Col " + (i + 1).ToString();
                uxGrid.Columns[i].Width = _cellSize;
                uxGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewRow row = new DataGridViewRow();
                row.Height = _cellSize;
                uxGrid.Rows.Add(row);
            }
            //marks the 3x3 grids
            uxGrid.Columns[2].DividerWidth = 2;
            uxGrid.Columns[5].DividerWidth = 2;
            uxGrid.Rows[2].DividerHeight = 2;
            uxGrid.Rows[5].DividerHeight = 2;

            //Demonstrates how to set cell values in the grid
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _cellsArray[i, j] = new Cell(i, j, -1);
                }
            }
        }

        /// <summary>
        /// Sets the value of a grid cell
        /// </summary>
        /// <param name="row">A row in the grid</param>
        /// <param name="col">A column in the grid</param>
        /// <param name="value">The value to place at that position</param>
        public void SetCell(int row, int col, int value)
        {
            uxGrid.Rows[row].Cells[col].Value = value;
        }

        /// <summary>
        /// Reads the file from the input and copies it to the array fiels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadAPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = uxOpenFileDialog.FileName;
                Cell[,] temp = new Cell[9, 9];
                using (StreamReader input = new StreamReader(fn))
                {
                    string[] wordsFromLine;
                    int row = 0;

                    while (!input.EndOfStream)
                    {
                        string line = input.ReadLine();
                        wordsFromLine = line.Split(' ');
                        int number = 0;
                        int col = 0;
                        foreach (string s in wordsFromLine)
                        {
                            if (s != "_")
                            {
                                number = int.Parse(s);
                                temp[row, col] = new Cell(row, col, number);
                                col++;
                            }
                            else if (s == "_")
                            {
                                number = -1;
                                temp[row, col] = new Cell(row, col, number);
                                col++;
                            }
                            else
                            {
                                MessageBox.Show("Invalid type of input");
                                return;
                            }
                        }
                        row++;
                    }
                    Array.Copy(temp, _cellsArray, temp.Length);
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (_cellsArray[i, j].Value > 0 && _cellsArray[i, j].Value < 10)
                            {
                                SetCell(i, j, (_cellsArray[i, j].Value));
                            }
                            else if (_cellsArray[i, j].Value == -1)
                            {
                                uxGrid.Rows[i].Cells[j].Value = "";
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Solves the Sudoku Puzzle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSolvePuzzle_Click(object sender, EventArgs e)
        {
            int p;
            _graph = new DirectedGraph<Cell, int>();
            int uncolored = 0;         
                AddNodes();
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                    Cell c = _cellsArray[x, y];
                    AddEdgesRC(c, out p);
                        if (p == 1)
                        {
                            return;
                        }
                            AddEdges3x3(c, out p);
                        if (p == 1)
                        {
                            return;
                        }
                    }
                }            
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (_cellsArray[i, j].Value == -1)//counter
                        {
                            uncolored++;
                        }
                    }
                }               
                    if (!SolveSudoku(uncolored, null))
                    {
                        MessageBox.Show("The solution has not been found");
                        return;
                    }
                    else// update each cell in uxGrid
                    {
                        for (int a = 0; a < 9; a++)
                        {
                            for (int j = 0; j < 9; j++)
                            {
                                if (_cellsArray[a, j].Value > 0 && _cellsArray[a, j].Value < 10)
                                {
                                    SetCell(a, j, (_cellsArray[a, j].Value));
                                }                        
                            }
                        }
                    }            
        }

        /// <summary>
        /// // edits the cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            Cell temp = null;
            try
            {
                if (Convert.ToInt32(uxGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < 0 || Convert.ToInt32(uxGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > 9)
                {
                    MessageBox.Show("Values must be between 1 and 9.");
                    uxGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";                   
                }
                else
                {
                    if (uxGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                    {
                        temp = new Cell(e.RowIndex, e.ColumnIndex, -1);
                    }
                    else if (uxGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != " ")
                    {
                        temp = new Cell(e.RowIndex, e.ColumnIndex, Convert.ToInt32(uxGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                    }                    
                    else
                    {
                        temp = new Cell(e.RowIndex, e.ColumnIndex, -1);
                    }
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show("Value must be between 1 and 9");
                uxGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                return;
            }
            _cellsArray[e.RowIndex, e.ColumnIndex] = temp;
        }

        /// <summary>
        /// Describing whether the Sudoku puzzle has a solution
        /// </summary>
        /// <param name="uncolored"></param>
        /// <param name="recent"></param>
        /// <returns>true-there is a solution, false - no solution</returns>
        private bool SolveSudoku(int uncolored, Cell recent)
        {
            Cell temp= null;
            if (recent == null)
            {
                recent = _cellsArray[0, 0];
            }        
            if (uncolored == 0)
            {
                return true;
            }
            else
            {
                temp = CellFinder(recent);            
                for (int i = 1; i < 10; i++)//For each available color for n
                {
                    if (temp.Moves[i] == false)
                    {
                        List<Cell> list = new List<Cell>(); //creating a list
                        temp.Value = i;    //Color n that color  
                        foreach (Tuple<Cell, int> b in _graph.OutgoingEdges(temp))// For each node adjacent to n
                        {
                            if (!b.Item1.Moves[i])
                            {

                                b.Item1.RemoveMove(i); //Remove that color from the available list for the adjacent node
                                list.Add(b.Item1); //Add the adjacent node to a list of affected nodes
                            }
                        }
                        //Recursively look for a solution in the resulting puzzle. 
                        if (SolveSudoku(uncolored - 1, temp))//If one is found, return true.
                        {
                            return true;
                        }
                        foreach (Cell c in list)// For each node adjacent to n    
                        {
                                c.AddMove(i); //Add that color back to the available list for the adjacent node                  
                        }                                              
                     }          
                }
            }
            temp.Value = -1;
            return false;
        }

        /// <summary>
        /// Finds the next availible cell
        /// </summary>
        /// <returns></returns>
        private Cell CellFinder(Cell c)
        {
            for (int i = c.Col; i < 9; i++)
            {
                if (_cellsArray[c.Row, i].Value == -1)
                {
                    return _cellsArray[c.Row, i];
                }
            }               
            for (int x = c.Row+1; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (_cellsArray[x, y].Value == -1)
                    {
                        return _cellsArray[x, y];                     
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Adds all nodes to the graph
        /// </summary>
        private void AddNodes()
        {        
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _graph.AddNode(_cellsArray[i, j]);                     
                }
            }      
        }

        /// <summary>
        /// Adds rows and columns, out int a-whether the puzzle follows the rules of sudoku, 1-yes, 0- no.
        /// </summary>
        private void AddEdgesRC(Cell c, out int a)
        {
                for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (c.Row == i ^ c.Col == j)
                            {
                                if (c.Value == _cellsArray[i, j].Value && c.Value != -1)
                                {
                                    MessageBox.Show("Initial puzzle does not follow Sudoku rules.");
                                    a = 1;
                                    return;
                                }
                                _graph.AddEdge(c, _cellsArray[i,j],0);
                                if (c.Value !=-1)
                                {
                                    _cellsArray[i, j].RemoveMove(c.Value);
                                }
                                if (_cellsArray[i, j].Value != -1)
                                {
                                    c.RemoveMove(_cellsArray[i, j].Value);
                                }
                            }
                        }         
                     }
                a = 0;          
          }

        /// <summary>
        /// Add edges for each cell, out int a-whether the puzzle follows the rules of sudoku, 1-yes, 0- no
        /// </summary>
        private void AddEdges3x3(Cell c, out int a)
        {         
        int graphCol = c.Col - c.Col % 3;
        int graphRow = c.Row - c.Row % 3;
            for (int x = graphRow; x < 3 + graphRow; x++)
            {
                for (int y = graphCol; y < 3 + graphCol; y++)
                {                    
                    if (c.Row != x && c.Col!=y)
                    {
                        if (c.Value == _cellsArray[x, y].Value && c.Value != -1)
                        {
                            MessageBox.Show("Initial puzzle does not follow Sudoku rules");
                            a = 1;
                            return;
                        }
                        _graph.AddEdge(c, _cellsArray[x, y], 0);
                        if (c.Value != -1)
                        {
                                _cellsArray[x, y].RemoveMove(c.Value);
                        }
                        if (_cellsArray[x, y].Value != -1)
                        {
                                c.RemoveMove(_cellsArray[x, y].Value);
                        }
                    }                         
                 }                            
            }
            a = 0;
         }
    }
}


