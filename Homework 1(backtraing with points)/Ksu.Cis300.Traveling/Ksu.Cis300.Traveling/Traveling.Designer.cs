namespace Ksu.Cis300.Traveling
{
    partial class Traveling
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
            this.uxDrawingPanel = new Ksu.Cis300.Drawing.DrawingPanel();
            this.uxFindTour = new System.Windows.Forms.Button();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxDrawingPanel
            // 
            this.uxDrawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDrawingPanel.BackColor = System.Drawing.Color.White;
            this.uxDrawingPanel.Location = new System.Drawing.Point(15, 24);
            this.uxDrawingPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxDrawingPanel.Name = "uxDrawingPanel";
            this.uxDrawingPanel.Size = new System.Drawing.Size(751, 898);
            this.uxDrawingPanel.TabIndex = 0;
            this.uxDrawingPanel.Load += new System.EventHandler(this.uxDrawingPanel_Load);
            // 
            // uxFindTour
            // 
            this.uxFindTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFindTour.Location = new System.Drawing.Point(784, 85);
            this.uxFindTour.Name = "uxFindTour";
            this.uxFindTour.Size = new System.Drawing.Size(270, 109);
            this.uxFindTour.TabIndex = 1;
            this.uxFindTour.Text = "Find Tour";
            this.uxFindTour.UseVisualStyleBackColor = true;
            this.uxFindTour.Click += new System.EventHandler(this.uxFindTour_Click);
            // 
            // uxClear
            // 
            this.uxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxClear.Location = new System.Drawing.Point(784, 210);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(270, 109);
            this.uxClear.TabIndex = 2;
            this.uxClear.Text = "Clear";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxListBox
            // 
            this.uxListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxListBox.FormattingEnabled = true;
            this.uxListBox.ItemHeight = 25;
            this.uxListBox.Location = new System.Drawing.Point(784, 340);
            this.uxListBox.Name = "uxListBox";
            this.uxListBox.Size = new System.Drawing.Size(270, 479);
            this.uxListBox.TabIndex = 3;
            this.uxListBox.SelectedIndexChanged += new System.EventHandler(this.uxListBox_SelectedIndexChanged);
            // 
            // Traveling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 937);
            this.Controls.Add(this.uxListBox);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxFindTour);
            this.Controls.Add(this.uxDrawingPanel);
            this.Name = "Traveling";
            this.Text = "Homework 1";
            this.Load += new System.EventHandler(this.Traveling_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Drawing.DrawingPanel uxDrawingPanel;
        private System.Windows.Forms.Button uxFindTour;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.ListBox uxListBox;
    }
}

