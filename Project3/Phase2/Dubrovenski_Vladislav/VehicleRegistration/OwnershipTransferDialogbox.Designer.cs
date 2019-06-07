namespace VehicleRegistration
{
    partial class OwnershipTransferDialogbox
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
            this.rbFromDealer = new System.Windows.Forms.RadioButton();
            this.rbFromPrivateOwner = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFromDealerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFromSSN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbToSSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbToDealerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbToPrivateOwner = new System.Windows.Forms.RadioButton();
            this.rbToDealer = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLicenceNumber = new System.Windows.Forms.TextBox();
            this.bnOK = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbFromDealer
            // 
            this.rbFromDealer.AutoSize = true;
            this.rbFromDealer.Location = new System.Drawing.Point(15, 21);
            this.rbFromDealer.Name = "rbFromDealer";
            this.rbFromDealer.Size = new System.Drawing.Size(56, 17);
            this.rbFromDealer.TabIndex = 1;
            this.rbFromDealer.TabStop = true;
            this.rbFromDealer.Text = "Dealer";
            this.rbFromDealer.UseVisualStyleBackColor = true;
            // 
            // rbFromPrivateOwner
            // 
            this.rbFromPrivateOwner.AutoSize = true;
            this.rbFromPrivateOwner.Location = new System.Drawing.Point(15, 44);
            this.rbFromPrivateOwner.Name = "rbFromPrivateOwner";
            this.rbFromPrivateOwner.Size = new System.Drawing.Size(92, 17);
            this.rbFromPrivateOwner.TabIndex = 2;
            this.rbFromPrivateOwner.TabStop = true;
            this.rbFromPrivateOwner.Text = "Private Owner";
            this.rbFromPrivateOwner.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dealer ID";
            // 
            // tbFromDealerID
            // 
            this.tbFromDealerID.Location = new System.Drawing.Point(186, 20);
            this.tbFromDealerID.Name = "tbFromDealerID";
            this.tbFromDealerID.Size = new System.Drawing.Size(100, 20);
            this.tbFromDealerID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SSN";
            // 
            // tbFromSSN
            // 
            this.tbFromSSN.Location = new System.Drawing.Point(186, 46);
            this.tbFromSSN.Name = "tbFromSSN";
            this.tbFromSSN.Size = new System.Drawing.Size(100, 20);
            this.tbFromSSN.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFromSSN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFromDealerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbFromPrivateOwner);
            this.groupBox1.Controls.Add(this.rbFromDealer);
            this.groupBox1.Location = new System.Drawing.Point(42, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbToSSN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbToDealerID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbToPrivateOwner);
            this.groupBox2.Controls.Add(this.rbToDealer);
            this.groupBox2.Location = new System.Drawing.Point(42, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 87);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // tbToSSN
            // 
            this.tbToSSN.Location = new System.Drawing.Point(186, 46);
            this.tbToSSN.Name = "tbToSSN";
            this.tbToSSN.Size = new System.Drawing.Size(100, 20);
            this.tbToSSN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SSN";
            // 
            // tbToDealerID
            // 
            this.tbToDealerID.Location = new System.Drawing.Point(186, 20);
            this.tbToDealerID.Name = "tbToDealerID";
            this.tbToDealerID.Size = new System.Drawing.Size(100, 20);
            this.tbToDealerID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dealer ID";
            // 
            // rbToPrivateOwner
            // 
            this.rbToPrivateOwner.AutoSize = true;
            this.rbToPrivateOwner.Location = new System.Drawing.Point(15, 44);
            this.rbToPrivateOwner.Name = "rbToPrivateOwner";
            this.rbToPrivateOwner.Size = new System.Drawing.Size(92, 17);
            this.rbToPrivateOwner.TabIndex = 2;
            this.rbToPrivateOwner.TabStop = true;
            this.rbToPrivateOwner.Text = "Private Owner";
            this.rbToPrivateOwner.UseVisualStyleBackColor = true;
            // 
            // rbToDealer
            // 
            this.rbToDealer.AutoSize = true;
            this.rbToDealer.Location = new System.Drawing.Point(15, 21);
            this.rbToDealer.Name = "rbToDealer";
            this.rbToDealer.Size = new System.Drawing.Size(56, 17);
            this.rbToDealer.TabIndex = 1;
            this.rbToDealer.TabStop = true;
            this.rbToDealer.Text = "Dealer";
            this.rbToDealer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "VIN";
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(81, 230);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(100, 20);
            this.tbVIN.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(234, 230);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(81, 267);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = " Licence Number (when selling to a private owner)";
            // 
            // tbLicenceNumber
            // 
            this.tbLicenceNumber.Location = new System.Drawing.Point(81, 332);
            this.tbLicenceNumber.Name = "tbLicenceNumber";
            this.tbLicenceNumber.Size = new System.Drawing.Size(100, 20);
            this.tbLicenceNumber.TabIndex = 16;
            // 
            // bnOK
            // 
            this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOK.Location = new System.Drawing.Point(106, 373);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(75, 23);
            this.bnOK.TabIndex = 17;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            // 
            // bnCancel
            // 
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(228, 373);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 23);
            this.bnCancel.TabIndex = 18;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // OwnershipTransferDialogbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 417);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.tbLicenceNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OwnershipTransferDialogbox";
            this.Text = "Ownership Transfer";
            this.Load += new System.EventHandler(this.OwnershipTransferDialogbox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFromDealer;
        private System.Windows.Forms.RadioButton rbFromPrivateOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFromDealerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFromSSN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbToSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbToDealerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbToPrivateOwner;
        private System.Windows.Forms.RadioButton rbToDealer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLicenceNumber;
        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.Button bnCancel;
    }
}