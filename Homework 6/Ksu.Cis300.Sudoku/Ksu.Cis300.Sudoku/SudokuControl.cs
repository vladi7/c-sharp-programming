using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TestGUI
{
    public class SudokuControl : System.Windows.Forms.UserControl
    {
        const int _colWidth = 45;
        const int _colHeight = 45;
        const int _gridSize = 9;
        const int _controlWidth = _colWidth * _gridSize + 3;
        DataGridView _grid;
        public SudokuControl()
        {
            _grid = new DataGridView();
            _grid.Name = "DGV";
            _grid.AllowUserToResizeColumns = false;
            _grid.AllowUserToResizeRows = false;
            _grid.AllowUserToAddRows = false;
            _grid.RowHeadersVisible = false;
            _grid.ColumnHeadersVisible = false;
            _grid.GridColor = Color.Black;
            _grid.DefaultCellStyle.BackColor = Color.White;
            _grid.ScrollBars = ScrollBars.None;
            _grid.Size = new Size(_controlWidth, _controlWidth);
            _grid.Location = new Point(50, 50);
            _grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            //DGV.ForeColor = Color.DarkBlue;
            _grid.Layout 

            // add 81 cells
            for (int i = 0; i < _gridSize; i++)
            {
                DataGridViewTextBoxColumn txCol = new DataGridViewTextBoxColumn();
                txCol.MaxInputLength = 1;   // only one digit allowed in a cell
                _grid.Columns.Add(txCol);
                _grid.Columns[i].Name = "Col " + (i + 1).ToString();
                _grid.Columns[i].Width = _colWidth;
                _grid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewRow row = new DataGridViewRow();
                row.Height = _colHeight;
                _grid.Rows.Add(row);
            }
            // mark the 9 square areas consisting of 9 cells
            _grid.Columns[2].DividerWidth = 2;
            _grid.Columns[5].DividerWidth = 2;
            _grid.Rows[2].DividerHeight = 2;
            _grid.Rows[5].DividerHeight = 2;

            Controls.Add(_grid);
        }

        public int GetCell(int row, int col)
        {
            return Convert.ToInt32(_grid.Rows[row].Cells[col].Value.ToString());
        }

        public void SetCell(int row, int col, int value)
        {
            _grid.Rows[row].Cells[col].Value = value;
        }

        public int this[int row, int col]
        {
            get
            {
                return Convert.ToInt32(_grid.Rows[row].Cells[col].Value.ToString());
            }
            set
            {
                _grid.Rows[row].Cells[col].Value = value;
            }
        }
    }
}
