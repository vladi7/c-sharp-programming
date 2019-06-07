namespace VehicleRegistration
{
    partial class TransferVehicleDealerDialogbox
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDealerID = new System.Windows.Forms.TextBox();
            this.bnOK = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Owned :";
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(65, 48);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(109, 20);
            this.tbVIN.TabIndex = 2;
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(65, 74);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(109, 20);
            this.tbMake.TabIndex = 3;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(65, 100);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(109, 20);
            this.tbModel.TabIndex = 4;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(65, 126);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(109, 20);
            this.tbYear.TabIndex = 5;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(65, 152);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(109, 20);
            this.tbColor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transfer to (Dealer):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DealerID";
            // 
            // tbDealerID
            // 
            this.tbDealerID.Location = new System.Drawing.Point(120, 216);
            this.tbDealerID.Name = "tbDealerID";
            this.tbDealerID.Size = new System.Drawing.Size(100, 20);
            this.tbDealerID.TabIndex = 9;
            // 
            // bnOK
            // 
            this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOK.Location = new System.Drawing.Point(49, 255);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(79, 21);
            this.bnOK.TabIndex = 10;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            // 
            // bnCancel
            // 
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(154, 253);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 23);
            this.bnCancel.TabIndex = 11;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // TransferVehicleDealerDialogbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.tbDealerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMake);
            this.Controls.Add(this.tbVIN);
            this.Controls.Add(this.label1);
            this.Name = "TransferVehicleDealerDialogbox";
            this.Text = "TransferVehecleDealerDialogbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDealerID;
        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.Button bnCancel;

    }
}