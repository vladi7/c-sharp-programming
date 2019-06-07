namespace VehicleRegistration
{
    partial class ListDialog
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
            this.lbList = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbList.FormattingEnabled = true;
            this.lbList.HorizontalScrollbar = true;
            this.lbList.Location = new System.Drawing.Point(32, 14);
            this.lbList.Name = "lbList";
            this.lbList.ScrollAlwaysVisible = true;
            this.lbList.Size = new System.Drawing.Size(404, 212);
            this.lbList.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDone.Location = new System.Drawing.Point(204, 250);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(78, 31);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // ListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 298);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbList);
            this.Name = "ListDialog";
            this.Text = "ListDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button btnDone;
    }
}