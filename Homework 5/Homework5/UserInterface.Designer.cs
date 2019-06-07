namespace Homework5
{
    partial class uxTextAnalyzer
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
            this.uxText1 = new System.Windows.Forms.Button();
            this.uxText2 = new System.Windows.Forms.Button();
            this.uxTextBox1 = new System.Windows.Forms.TextBox();
            this.uxTextBox2 = new System.Windows.Forms.TextBox();
            this.uxAnalyzeTexts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxText1
            // 
            this.uxText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxText1.Location = new System.Drawing.Point(23, 12);
            this.uxText1.Name = "uxText1";
            this.uxText1.Size = new System.Drawing.Size(234, 88);
            this.uxText1.TabIndex = 0;
            this.uxText1.Text = "Text 1";
            this.uxText1.UseVisualStyleBackColor = true;
            this.uxText1.Click += new System.EventHandler(this.uxText1_Click);
            // 
            // uxText2
            // 
            this.uxText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxText2.Location = new System.Drawing.Point(23, 106);
            this.uxText2.Name = "uxText2";
            this.uxText2.Size = new System.Drawing.Size(234, 88);
            this.uxText2.TabIndex = 1;
            this.uxText2.Text = "Text 2";
            this.uxText2.UseVisualStyleBackColor = true;
            this.uxText2.Click += new System.EventHandler(this.uxText2_Click);
            // 
            // uxTextBox1
            // 
            this.uxTextBox1.Enabled = false;
            this.uxTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox1.Location = new System.Drawing.Point(263, 32);
            this.uxTextBox1.Multiline = true;
            this.uxTextBox1.Name = "uxTextBox1";
            this.uxTextBox1.ReadOnly = true;
            this.uxTextBox1.Size = new System.Drawing.Size(915, 62);
            this.uxTextBox1.TabIndex = 2;
            // 
            // uxTextBox2
            // 
            this.uxTextBox2.Enabled = false;
            this.uxTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox2.Location = new System.Drawing.Point(263, 126);
            this.uxTextBox2.Multiline = true;
            this.uxTextBox2.Name = "uxTextBox2";
            this.uxTextBox2.ReadOnly = true;
            this.uxTextBox2.Size = new System.Drawing.Size(915, 64);
            this.uxTextBox2.TabIndex = 3;
            // 
            // uxAnalyzeTexts
            // 
            this.uxAnalyzeTexts.Enabled = false;
            this.uxAnalyzeTexts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAnalyzeTexts.Location = new System.Drawing.Point(23, 201);
            this.uxAnalyzeTexts.Name = "uxAnalyzeTexts";
            this.uxAnalyzeTexts.Size = new System.Drawing.Size(1155, 98);
            this.uxAnalyzeTexts.TabIndex = 4;
            this.uxAnalyzeTexts.Text = "Analyze Texts";
            this.uxAnalyzeTexts.UseVisualStyleBackColor = true;
            this.uxAnalyzeTexts.Click += new System.EventHandler(this.uxAnalyzeTexts_Click);
            // 
            // uxTextAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 311);
            this.Controls.Add(this.uxAnalyzeTexts);
            this.Controls.Add(this.uxTextBox2);
            this.Controls.Add(this.uxTextBox1);
            this.Controls.Add(this.uxText2);
            this.Controls.Add(this.uxText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "uxTextAnalyzer";
            this.Text = "Text Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxText1;
        private System.Windows.Forms.Button uxText2;
        private System.Windows.Forms.TextBox uxTextBox1;
        private System.Windows.Forms.TextBox uxTextBox2;
        private System.Windows.Forms.Button uxAnalyzeTexts;
    }
}

