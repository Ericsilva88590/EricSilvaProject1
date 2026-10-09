namespace EricSilvaProject1
{
    partial class CarLotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxInventory;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonViewDetails;
        private System.Windows.Forms.TextBox textBoxShopperName;
        private System.Windows.Forms.NumericUpDown numericUpDownMoney;
        private System.Windows.Forms.Button buttonCreateShopper;
        private System.Windows.Forms.Label labelShopperNameLabel;
        private System.Windows.Forms.Label labelShopperName;
        private System.Windows.Forms.Label labelMoneyLabel;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.ListBox listBoxOwned;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxInventory = new System.Windows.Forms.ListBox();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.textBoxShopperName = new System.Windows.Forms.TextBox();
            this.numericUpDownMoney = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateShopper = new System.Windows.Forms.Button();
            this.labelShopperNameLabel = new System.Windows.Forms.Label();
            this.labelShopperName = new System.Windows.Forms.Label();
            this.labelMoneyLabel = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.listBoxOwned = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxInventory
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.addCarToolStripMenuItem.Text = "Add Car...";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // listBoxInventory
            // 
            this.listBoxInventory.FormattingEnabled = true;
            this.listBoxInventory.ItemHeight = 15;
            this.listBoxInventory.Location = new System.Drawing.Point(12, 36);
            this.listBoxInventory.Name = "listBoxInventory";
            this.listBoxInventory.Size = new System.Drawing.Size(460, 199);
            this.listBoxInventory.TabIndex = 0;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(12, 217);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(120, 30);
            this.buttonPurchase.TabIndex = 1;
            this.buttonPurchase.Text = "Purchase Selected";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // buttonViewDetails
            // 
            this.buttonViewDetails.Location = new System.Drawing.Point(150, 217);
            this.buttonViewDetails.Name = "buttonViewDetails";
            this.buttonViewDetails.Size = new System.Drawing.Size(120, 30);
            this.buttonViewDetails.TabIndex = 10;
            this.buttonViewDetails.Text = "View Details";
            this.buttonViewDetails.UseVisualStyleBackColor = true;
            this.buttonViewDetails.Click += new System.EventHandler(this.buttonViewDetails_Click);
            // 
            // textBoxShopperName
            // 
            this.textBoxShopperName.Location = new System.Drawing.Point(500, 12);
            this.textBoxShopperName.Name = "textBoxShopperName";
            this.textBoxShopperName.Size = new System.Drawing.Size(200, 23);
            this.textBoxShopperName.TabIndex = 2;
            // 
            // numericUpDownMoney
            // 
            this.numericUpDownMoney.DecimalPlaces = 2;
            this.numericUpDownMoney.Location = new System.Drawing.Point(500, 41);
            this.numericUpDownMoney.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMoney.Name = "numericUpDownMoney";
            this.numericUpDownMoney.Size = new System.Drawing.Size(200, 23);
            this.numericUpDownMoney.TabIndex = 3;
            // 
            // buttonCreateShopper
            // 
            this.buttonCreateShopper.Location = new System.Drawing.Point(500, 70);
            this.buttonCreateShopper.Name = "buttonCreateShopper";
            this.buttonCreateShopper.Size = new System.Drawing.Size(200, 30);
            this.buttonCreateShopper.TabIndex = 4;
            this.buttonCreateShopper.Text = "Create Shopper";
            this.buttonCreateShopper.UseVisualStyleBackColor = true;
            this.buttonCreateShopper.Click += new System.EventHandler(this.buttonCreateShopper_Click);
            // 
            // labelShopperNameLabel
            // 
            this.labelShopperNameLabel.AutoSize = true;
            this.labelShopperNameLabel.Location = new System.Drawing.Point(500, 110);
            this.labelShopperNameLabel.Name = "labelShopperNameLabel";
            this.labelShopperNameLabel.Size = new System.Drawing.Size(42, 15);
            this.labelShopperNameLabel.TabIndex = 5;
            this.labelShopperNameLabel.Text = "Shopper:";
            // 
            // labelShopperName
            // 
            this.labelShopperName.AutoSize = true;
            this.labelShopperName.Location = new System.Drawing.Point(560, 110);
            this.labelShopperName.Name = "labelShopperName";
            this.labelShopperName.Size = new System.Drawing.Size(57, 15);
            this.labelShopperName.TabIndex = 6;
            this.labelShopperName.Text = "No shopper";
            // 
            // labelMoneyLabel
            // 
            this.labelMoneyLabel.AutoSize = true;
            this.labelMoneyLabel.Location = new System.Drawing.Point(500, 130);
            this.labelMoneyLabel.Name = "labelMoneyLabel";
            this.labelMoneyLabel.Size = new System.Drawing.Size(41, 15);
            this.labelMoneyLabel.TabIndex = 7;
            this.labelMoneyLabel.Text = "Money:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(560, 130);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(34, 15);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "$0.00";
            // 
            // listBoxOwned
            // 
            this.listBoxOwned.FormattingEnabled = true;
            this.listBoxOwned.ItemHeight = 15;
            this.listBoxOwned.Location = new System.Drawing.Point(500, 160);
            this.listBoxOwned.Name = "listBoxOwned";
            this.listBoxOwned.Size = new System.Drawing.Size(268, 94);
            this.listBoxOwned.TabIndex = 9;
            // 
            // CarLotForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.listBoxOwned);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelMoneyLabel);
            this.Controls.Add(this.labelShopperName);
            this.Controls.Add(this.labelShopperNameLabel);
            this.Controls.Add(this.buttonCreateShopper);
            this.Controls.Add(this.numericUpDownMoney);
            this.Controls.Add(this.textBoxShopperName);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.listBoxInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CarLotForm";
            this.Text = "Car Lot";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
