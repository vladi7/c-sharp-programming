namespace Ksu.Cis300.TravelingSalesperson
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
            this.uxPanel = new Ksu.Cis300.Drawing.DrawingPanel();
            this.uxTourPoints = new System.Windows.Forms.ListBox();
            this.uxFindTour = new System.Windows.Forms.Button();
            this.uxClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPanel
            // 
            this.uxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPanel.BackColor = System.Drawing.Color.White;
            this.uxPanel.Location = new System.Drawing.Point(12, 12);
            this.uxPanel.Name = "uxPanel";
            this.uxPanel.Size = new System.Drawing.Size(389, 426);
            this.uxPanel.TabIndex = 0;
            // 
            // uxTourPoints
            // 
            this.uxTourPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTourPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTourPoints.FormattingEnabled = true;
            this.uxTourPoints.ItemHeight = 24;
            this.uxTourPoints.Location = new System.Drawing.Point(407, 96);
            this.uxTourPoints.Name = "uxTourPoints";
            this.uxTourPoints.Size = new System.Drawing.Size(174, 340);
            this.uxTourPoints.TabIndex = 1;
            // 
            // uxFindTour
            // 
            this.uxFindTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFindTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindTour.Location = new System.Drawing.Point(407, 12);
            this.uxFindTour.Name = "uxFindTour";
            this.uxFindTour.Size = new System.Drawing.Size(174, 36);
            this.uxFindTour.TabIndex = 2;
            this.uxFindTour.Text = "Find Tour";
            this.uxFindTour.UseVisualStyleBackColor = true;
            this.uxFindTour.Click += new System.EventHandler(this.uxFindTour_Click);
            // 
            // uxClear
            // 
            this.uxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClear.Location = new System.Drawing.Point(407, 54);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(174, 36);
            this.uxClear.TabIndex = 3;
            this.uxClear.Text = "Clear";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxFindTour);
            this.Controls.Add(this.uxTourPoints);
            this.Controls.Add(this.uxPanel);
            this.MinimumSize = new System.Drawing.Size(340, 270);
            this.Name = "UserInterface";
            this.Text = "Traveling Salesperson";
            this.ResumeLayout(false);

        }

        #endregion

        private Drawing.DrawingPanel uxPanel;
        private System.Windows.Forms.ListBox uxTourPoints;
        private System.Windows.Forms.Button uxFindTour;
        private System.Windows.Forms.Button uxClear;
    }
}

