namespace VehicleRegistration
{
    partial class VehicleRegistrationSystem
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
            this.bnRegVehicle = new System.Windows.Forms.Button();
            this.bnRegDealer = new System.Windows.Forms.Button();
            this.bnRegOwner = new System.Windows.Forms.Button();
            this.bnTransfer = new System.Windows.Forms.Button();
            this.bnListOwnedVehicles = new System.Windows.Forms.Button();
            this.ListOwnersHistory = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.bnRestore = new System.Windows.Forms.Button();
            this.bnDone = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnListDealers = new System.Windows.Forms.Button();
            this.bnListOwners = new System.Windows.Forms.Button();
            this.bnListVehicles = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnRegVehicle
            // 
            this.bnRegVehicle.Location = new System.Drawing.Point(14, 52);
            this.bnRegVehicle.Name = "bnRegVehicle";
            this.bnRegVehicle.Size = new System.Drawing.Size(117, 23);
            this.bnRegVehicle.TabIndex = 0;
            this.bnRegVehicle.Text = "Register  Vehicle";
            this.bnRegVehicle.UseVisualStyleBackColor = true;
            this.bnRegVehicle.Click += new System.EventHandler(this.bnRegVehicle_Click);
            // 
            // bnRegDealer
            // 
            this.bnRegDealer.Location = new System.Drawing.Point(14, 19);
            this.bnRegDealer.Name = "bnRegDealer";
            this.bnRegDealer.Size = new System.Drawing.Size(117, 27);
            this.bnRegDealer.TabIndex = 1;
            this.bnRegDealer.Text = "Register Dealer";
            this.bnRegDealer.UseVisualStyleBackColor = true;
            this.bnRegDealer.Click += new System.EventHandler(this.bnRegDealer_Click);
            // 
            // bnRegOwner
            // 
            this.bnRegOwner.Location = new System.Drawing.Point(14, 81);
            this.bnRegOwner.Name = "bnRegOwner";
            this.bnRegOwner.Size = new System.Drawing.Size(117, 23);
            this.bnRegOwner.TabIndex = 2;
            this.bnRegOwner.Text = "Register Owner";
            this.bnRegOwner.UseVisualStyleBackColor = true;
            this.bnRegOwner.Click += new System.EventHandler(this.bnRegOwner_Click);
            // 
            // bnTransfer
            // 
            this.bnTransfer.Location = new System.Drawing.Point(14, 19);
            this.bnTransfer.Name = "bnTransfer";
            this.bnTransfer.Size = new System.Drawing.Size(117, 23);
            this.bnTransfer.TabIndex = 3;
            this.bnTransfer.Text = "Transfer Ownership";
            this.bnTransfer.UseVisualStyleBackColor = true;
            this.bnTransfer.Click += new System.EventHandler(this.bnTransfer_Click);
            // 
            // bnListOwnedVehicles
            // 
            this.bnListOwnedVehicles.Location = new System.Drawing.Point(14, 48);
            this.bnListOwnedVehicles.Name = "bnListOwnedVehicles";
            this.bnListOwnedVehicles.Size = new System.Drawing.Size(117, 25);
            this.bnListOwnedVehicles.TabIndex = 4;
            this.bnListOwnedVehicles.Text = "List Owned Vehicles";
            this.bnListOwnedVehicles.UseVisualStyleBackColor = true;
            this.bnListOwnedVehicles.Click += new System.EventHandler(this.bnListOwnedVehicles_Click);
            // 
            // ListOwnersHistory
            // 
            this.ListOwnersHistory.Location = new System.Drawing.Point(14, 79);
            this.ListOwnersHistory.Name = "ListOwnersHistory";
            this.ListOwnersHistory.Size = new System.Drawing.Size(117, 23);
            this.ListOwnersHistory.TabIndex = 5;
            this.ListOwnersHistory.Text = "List Owners History\r\n";
            this.ListOwnersHistory.UseVisualStyleBackColor = true;
            this.ListOwnersHistory.Click += new System.EventHandler(this.ListOwnersHistory_Click);
            // 
            // bnSave
            // 
            this.bnSave.Location = new System.Drawing.Point(14, 48);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(115, 23);
            this.bnSave.TabIndex = 6;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // bnRestore
            // 
            this.bnRestore.Location = new System.Drawing.Point(14, 77);
            this.bnRestore.Name = "bnRestore";
            this.bnRestore.Size = new System.Drawing.Size(115, 23);
            this.bnRestore.TabIndex = 7;
            this.bnRestore.Text = "Restore";
            this.bnRestore.UseVisualStyleBackColor = true;
            this.bnRestore.Click += new System.EventHandler(this.bnRestore_Click);
            // 
            // bnDone
            // 
            this.bnDone.Location = new System.Drawing.Point(149, 291);
            this.bnDone.Name = "bnDone";
            this.bnDone.Size = new System.Drawing.Size(69, 29);
            this.bnDone.TabIndex = 8;
            this.bnDone.Text = "Done";
            this.bnDone.UseVisualStyleBackColor = true;
            this.bnDone.Click += new System.EventHandler(this.bnDone_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bnLoad);
            this.groupBox1.Controls.Add(this.bnRestore);
            this.groupBox1.Controls.Add(this.bnSave);
            this.groupBox1.Location = new System.Drawing.Point(195, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // bnLoad
            // 
            this.bnLoad.Location = new System.Drawing.Point(14, 19);
            this.bnLoad.Name = "bnLoad";
            this.bnLoad.Size = new System.Drawing.Size(115, 23);
            this.bnLoad.TabIndex = 8;
            this.bnLoad.Text = "Load";
            this.bnLoad.UseVisualStyleBackColor = true;
            this.bnLoad.Click += new System.EventHandler(this.bnLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.bnRegOwner);
            this.groupBox2.Controls.Add(this.bnRegDealer);
            this.groupBox2.Controls.Add(this.bnRegVehicle);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 119);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registration";
            // 
            // bnListDealers
            // 
            this.bnListDealers.Location = new System.Drawing.Point(16, 19);
            this.bnListDealers.Name = "bnListDealers";
            this.bnListDealers.Size = new System.Drawing.Size(117, 23);
            this.bnListDealers.TabIndex = 8;
            this.bnListDealers.Text = "List Dealers";
            this.bnListDealers.UseVisualStyleBackColor = true;
            this.bnListDealers.Click += new System.EventHandler(this.bnListDealers_Click);
            // 
            // bnListOwners
            // 
            this.bnListOwners.Location = new System.Drawing.Point(16, 75);
            this.bnListOwners.Name = "bnListOwners";
            this.bnListOwners.Size = new System.Drawing.Size(117, 23);
            this.bnListOwners.TabIndex = 7;
            this.bnListOwners.Text = "List Owners";
            this.bnListOwners.UseVisualStyleBackColor = true;
            this.bnListOwners.Click += new System.EventHandler(this.bnListOwners_Click);
            // 
            // bnListVehicles
            // 
            this.bnListVehicles.Location = new System.Drawing.Point(14, 48);
            this.bnListVehicles.Name = "bnListVehicles";
            this.bnListVehicles.Size = new System.Drawing.Size(119, 23);
            this.bnListVehicles.TabIndex = 6;
            this.bnListVehicles.Text = "List Vehicles";
            this.bnListVehicles.UseVisualStyleBackColor = true;
            this.bnListVehicles.Click += new System.EventHandler(this.bnListVehicles_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.ListOwnersHistory);
            this.groupBox3.Controls.Add(this.bnTransfer);
            this.groupBox3.Controls.Add(this.bnListOwnedVehicles);
            this.groupBox3.Location = new System.Drawing.Point(197, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 119);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ownership";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.bnListOwners);
            this.groupBox4.Controls.Add(this.bnListDealers);
            this.groupBox4.Controls.Add(this.bnListVehicles);
            this.groupBox4.Location = new System.Drawing.Point(22, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 115);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List";
            // 
            // VehicleRegistrationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 341);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnDone);
            this.Name = "VehicleRegistrationSystem";
            this.Text = "Vehicle Registration System";
            this.Load += new System.EventHandler(this.VehicleRegistrationSystem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnRegVehicle;
        private System.Windows.Forms.Button bnRegDealer;
        private System.Windows.Forms.Button bnRegOwner;
        private System.Windows.Forms.Button bnTransfer;
        private System.Windows.Forms.Button bnListOwnedVehicles;
        private System.Windows.Forms.Button ListOwnersHistory;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Button bnRestore;
        private System.Windows.Forms.Button bnDone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnListVehicles;
        private System.Windows.Forms.Button bnListDealers;
        private System.Windows.Forms.Button bnListOwners;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnLoad;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

