namespace Ksu.Cis300.Sudoku
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uxPanel = new System.Windows.Forms.Panel();
            this.uxGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSolvePuzzle = new System.Windows.Forms.Button();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPanel
            // 
            this.uxPanel.Controls.Add(this.uxGrid);
            this.uxPanel.Location = new System.Drawing.Point(83, 93);
            this.uxPanel.Margin = new System.Windows.Forms.Padding(4);
            this.uxPanel.Name = "uxPanel";
            this.uxPanel.Size = new System.Drawing.Size(720, 688);
            this.uxPanel.TabIndex = 0;
            // 
            // uxGrid
            // 
            this.uxGrid.AllowUserToAddRows = false;
            this.uxGrid.AllowUserToDeleteRows = false;
            this.uxGrid.AllowUserToResizeColumns = false;
            this.uxGrid.AllowUserToResizeRows = false;
            this.uxGrid.BackgroundColor = System.Drawing.Color.White;
            this.uxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.uxGrid.Location = new System.Drawing.Point(0, 0);
            this.uxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.uxGrid.Name = "uxGrid";
            this.uxGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.uxGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.uxGrid.RowTemplate.Height = 28;
            this.uxGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.uxGrid.Size = new System.Drawing.Size(720, 688);
            this.uxGrid.TabIndex = 0;
            this.uxGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxGrid_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAPuzzleToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // loadAPuzzleToolStripMenuItem
            // 
            this.loadAPuzzleToolStripMenuItem.Name = "loadAPuzzleToolStripMenuItem";
            this.loadAPuzzleToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.loadAPuzzleToolStripMenuItem.Text = "Load a Puzzle";
            this.loadAPuzzleToolStripMenuItem.Click += new System.EventHandler(this.loadAPuzzleToolStripMenuItem_Click);
            // 
            // uxSolvePuzzle
            // 
            this.uxSolvePuzzle.Location = new System.Drawing.Point(262, 812);
            this.uxSolvePuzzle.Name = "uxSolvePuzzle";
            this.uxSolvePuzzle.Size = new System.Drawing.Size(376, 61);
            this.uxSolvePuzzle.TabIndex = 2;
            this.uxSolvePuzzle.Text = "Solve Puzzle";
            this.uxSolvePuzzle.UseVisualStyleBackColor = true;
            this.uxSolvePuzzle.Click += new System.EventHandler(this.uxSolvePuzzle_Click);
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "uxOpenFileDialog";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 943);
            this.Controls.Add(this.uxSolvePuzzle);
            this.Controls.Add(this.uxPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Sudoku Solver";
            this.uxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel uxPanel;
        private System.Windows.Forms.DataGridView uxGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAPuzzleToolStripMenuItem;
        private System.Windows.Forms.Button uxSolvePuzzle;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
    }
}

