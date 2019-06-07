namespace Ksu.Cis300.NameLookup
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
            this.uxOpen = new System.Windows.Forms.Button();
            this.uxRank = new System.Windows.Forms.TextBox();
            this.uxRankLabel = new System.Windows.Forms.Label();
            this.uxFrequency = new System.Windows.Forms.TextBox();
            this.uxFrequencyLabel = new System.Windows.Forms.Label();
            this.uxLookup = new System.Windows.Forms.Button();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxPanel2 = new System.Windows.Forms.Panel();
            this.uxFindTextBox = new System.Windows.Forms.TextBox();
            this.uxFind = new System.Windows.Forms.Button();
            this.uxCountTextBox = new System.Windows.Forms.TextBox();
            this.uxCount = new System.Windows.Forms.Button();
            this.uxFirstLetter = new System.Windows.Forms.TextBox();
            this.uxFirstLetterLabel = new System.Windows.Forms.Label();
            this.uxOutput = new System.Windows.Forms.Button();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxPanel1 = new System.Windows.Forms.Panel();
            this.uxPanel2.SuspendLayout();
            this.uxPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxOpen
            // 
            this.uxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpen.Location = new System.Drawing.Point(30, 17);
            this.uxOpen.Margin = new System.Windows.Forms.Padding(6);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(620, 79);
            this.uxOpen.TabIndex = 31;
            this.uxOpen.Text = "Open Data File";
            this.uxOpen.UseVisualStyleBackColor = true;
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxRank
            // 
            this.uxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRank.Location = new System.Drawing.Point(151, 320);
            this.uxRank.Margin = new System.Windows.Forms.Padding(6);
            this.uxRank.Name = "uxRank";
            this.uxRank.ReadOnly = true;
            this.uxRank.Size = new System.Drawing.Size(496, 51);
            this.uxRank.TabIndex = 30;
            this.uxRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxRankLabel
            // 
            this.uxRankLabel.AutoSize = true;
            this.uxRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRankLabel.Location = new System.Drawing.Point(22, 320);
            this.uxRankLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxRankLabel.Name = "uxRankLabel";
            this.uxRankLabel.Size = new System.Drawing.Size(119, 44);
            this.uxRankLabel.TabIndex = 29;
            this.uxRankLabel.Text = "Rank:";
            // 
            // uxFrequency
            // 
            this.uxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFrequency.Location = new System.Drawing.Point(249, 266);
            this.uxFrequency.Margin = new System.Windows.Forms.Padding(6);
            this.uxFrequency.Name = "uxFrequency";
            this.uxFrequency.ReadOnly = true;
            this.uxFrequency.Size = new System.Drawing.Size(398, 51);
            this.uxFrequency.TabIndex = 28;
            this.uxFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uxFrequencyLabel
            // 
            this.uxFrequencyLabel.AutoSize = true;
            this.uxFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFrequencyLabel.Location = new System.Drawing.Point(22, 266);
            this.uxFrequencyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxFrequencyLabel.Name = "uxFrequencyLabel";
            this.uxFrequencyLabel.Size = new System.Drawing.Size(210, 44);
            this.uxFrequencyLabel.TabIndex = 27;
            this.uxFrequencyLabel.Text = "Frequency:";
            // 
            // uxLookup
            // 
            this.uxLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLookup.Location = new System.Drawing.Point(30, 164);
            this.uxLookup.Margin = new System.Windows.Forms.Padding(6);
            this.uxLookup.Name = "uxLookup";
            this.uxLookup.Size = new System.Drawing.Size(620, 79);
            this.uxLookup.TabIndex = 26;
            this.uxLookup.Text = "Get Statistics";
            this.uxLookup.UseVisualStyleBackColor = true;
            this.uxLookup.Click += new System.EventHandler(this.uxLookup_Click);
            // 
            // uxName
            // 
            this.uxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxName.Location = new System.Drawing.Point(167, 99);
            this.uxName.Margin = new System.Windows.Forms.Padding(6);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(480, 51);
            this.uxName.TabIndex = 25;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(26, 99);
            this.uxNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(133, 44);
            this.uxNameLabel.TabIndex = 24;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxPanel2
            // 
            this.uxPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxPanel2.Controls.Add(this.uxFindTextBox);
            this.uxPanel2.Controls.Add(this.uxFind);
            this.uxPanel2.Controls.Add(this.uxCountTextBox);
            this.uxPanel2.Controls.Add(this.uxCount);
            this.uxPanel2.Controls.Add(this.uxFirstLetter);
            this.uxPanel2.Controls.Add(this.uxFirstLetterLabel);
            this.uxPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPanel2.Location = new System.Drawing.Point(731, 43);
            this.uxPanel2.Name = "uxPanel2";
            this.uxPanel2.Size = new System.Drawing.Size(571, 460);
            this.uxPanel2.TabIndex = 32;
            // 
            // uxFindTextBox
            // 
            this.uxFindTextBox.Location = new System.Drawing.Point(25, 357);
            this.uxFindTextBox.Multiline = true;
            this.uxFindTextBox.Name = "uxFindTextBox";
            this.uxFindTextBox.Size = new System.Drawing.Size(509, 87);
            this.uxFindTextBox.TabIndex = 5;
            // 
            // uxFind
            // 
            this.uxFind.Location = new System.Drawing.Point(25, 277);
            this.uxFind.Name = "uxFind";
            this.uxFind.Size = new System.Drawing.Size(509, 74);
            this.uxFind.TabIndex = 4;
            this.uxFind.Text = "Find Most Common Letter";
            this.uxFind.UseVisualStyleBackColor = true;
            this.uxFind.Click += new System.EventHandler(this.uxFind_Click);
            // 
            // uxCountTextBox
            // 
            this.uxCountTextBox.Location = new System.Drawing.Point(25, 177);
            this.uxCountTextBox.Multiline = true;
            this.uxCountTextBox.Name = "uxCountTextBox";
            this.uxCountTextBox.Size = new System.Drawing.Size(509, 87);
            this.uxCountTextBox.TabIndex = 3;
            // 
            // uxCount
            // 
            this.uxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCount.Location = new System.Drawing.Point(25, 97);
            this.uxCount.Name = "uxCount";
            this.uxCount.Size = new System.Drawing.Size(509, 74);
            this.uxCount.TabIndex = 2;
            this.uxCount.Text = "Count Names with Letter";
            this.uxCount.UseVisualStyleBackColor = true;
            this.uxCount.Click += new System.EventHandler(this.uxCount_Click);
            // 
            // uxFirstLetter
            // 
            this.uxFirstLetter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxFirstLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFirstLetter.Location = new System.Drawing.Point(249, 33);
            this.uxFirstLetter.Name = "uxFirstLetter";
            this.uxFirstLetter.Size = new System.Drawing.Size(285, 42);
            this.uxFirstLetter.TabIndex = 1;
            // 
            // uxFirstLetterLabel
            // 
            this.uxFirstLetterLabel.AutoSize = true;
            this.uxFirstLetterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFirstLetterLabel.Location = new System.Drawing.Point(51, 33);
            this.uxFirstLetterLabel.Name = "uxFirstLetterLabel";
            this.uxFirstLetterLabel.Size = new System.Drawing.Size(192, 42);
            this.uxFirstLetterLabel.TabIndex = 0;
            this.uxFirstLetterLabel.Text = "First letter:";
            // 
            // uxOutput
            // 
            this.uxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOutput.Location = new System.Drawing.Point(34, 378);
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.Size = new System.Drawing.Size(616, 68);
            this.uxOutput.TabIndex = 33;
            this.uxOutput.Text = "Output Sorted File";
            this.uxOutput.UseVisualStyleBackColor = true;
            this.uxOutput.Click += new System.EventHandler(this.uxOutput_Click);
            // 
            // uxPanel1
            // 
            this.uxPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxPanel1.Controls.Add(this.uxOpen);
            this.uxPanel1.Controls.Add(this.uxOutput);
            this.uxPanel1.Controls.Add(this.uxNameLabel);
            this.uxPanel1.Controls.Add(this.uxName);
            this.uxPanel1.Controls.Add(this.uxRank);
            this.uxPanel1.Controls.Add(this.uxLookup);
            this.uxPanel1.Controls.Add(this.uxRankLabel);
            this.uxPanel1.Controls.Add(this.uxFrequencyLabel);
            this.uxPanel1.Controls.Add(this.uxFrequency);
            this.uxPanel1.Location = new System.Drawing.Point(36, 43);
            this.uxPanel1.Name = "uxPanel1";
            this.uxPanel1.Size = new System.Drawing.Size(689, 460);
            this.uxPanel1.TabIndex = 34;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 534);
            this.Controls.Add(this.uxPanel1);
            this.Controls.Add(this.uxPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Name Lookup";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.uxPanel2.ResumeLayout(false);
            this.uxPanel2.PerformLayout();
            this.uxPanel1.ResumeLayout(false);
            this.uxPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxOpen;
        private System.Windows.Forms.TextBox uxRank;
        private System.Windows.Forms.Label uxRankLabel;
        private System.Windows.Forms.TextBox uxFrequency;
        private System.Windows.Forms.Label uxFrequencyLabel;
        private System.Windows.Forms.Button uxLookup;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.Panel uxPanel2;
        private System.Windows.Forms.TextBox uxFindTextBox;
        private System.Windows.Forms.Button uxFind;
        private System.Windows.Forms.TextBox uxCountTextBox;
        private System.Windows.Forms.Button uxCount;
        private System.Windows.Forms.TextBox uxFirstLetter;
        private System.Windows.Forms.Label uxFirstLetterLabel;
        private System.Windows.Forms.Button uxOutput;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.Panel uxPanel1;
    }
}

