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
        private System.Windows.Forms.SplitContainer splitContainerMain;
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.textBoxShopperName = new System.Windows.Forms.TextBox();
            this.numericUpDownMoney = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateShopper = new System.Windows.Forms.Button();
            this.labelShopperNameLabel = new System.Windows.Forms.Label();
            this.labelShopperName = new System.Windows.Forms.Label();
            this.labelMoneyLabel = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.listBoxOwned = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxInventory
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.MainMenuStrip = this.menuStrip1;
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
            this.listBoxInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInventory.Name = "listBoxInventory";
            this.listBoxInventory.TabIndex = 0;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(12, 6);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(140, 30);
            this.buttonPurchase.TabIndex = 1;
            this.buttonPurchase.Text = "Purchase Selected";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // buttonViewDetails
            // 
            this.buttonViewDetails = new System.Windows.Forms.Button();
            this.buttonViewDetails.Location = new System.Drawing.Point(160, 6);
            this.buttonViewDetails.Name = "buttonViewDetails";
            this.buttonViewDetails.Size = new System.Drawing.Size(140, 30);
            this.buttonViewDetails.TabIndex = 10;
            this.buttonViewDetails.Text = "View Details";
            this.buttonViewDetails.UseVisualStyleBackColor = true;
            this.buttonViewDetails.Click += new System.EventHandler(this.buttonViewDetails_Click);
            // 
            // textBoxShopperName
            // 
            this.textBoxShopperName.Location = new System.Drawing.Point(80, 6);
            this.textBoxShopperName.Name = "textBoxShopperName";
            this.textBoxShopperName.Size = new System.Drawing.Size(200, 23);
            this.textBoxShopperName.TabIndex = 2;
            this.textBoxShopperName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // numericUpDownMoney
            // 
            this.numericUpDownMoney.DecimalPlaces = 2;
            this.numericUpDownMoney.Location = new System.Drawing.Point(80, 36);
            this.numericUpDownMoney.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMoney.Name = "numericUpDownMoney";
            this.numericUpDownMoney.Size = new System.Drawing.Size(200, 23);
            this.numericUpDownMoney.TabIndex = 3;
            this.numericUpDownMoney.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // buttonCreateShopper
            // 
            this.buttonCreateShopper.Location = new System.Drawing.Point(300, 6);
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
            this.labelShopperNameLabel.Location = new System.Drawing.Point(12, 9);
            this.labelShopperNameLabel.Name = "labelShopperNameLabel";
            this.labelShopperNameLabel.Size = new System.Drawing.Size(38, 15);
            this.labelShopperNameLabel.TabIndex = 5;
            this.labelShopperNameLabel.Text = "Name:";
            // 
            // labelShopperName
            // 
            this.labelShopperName.AutoSize = true;
            this.labelShopperName.Location = new System.Drawing.Point(12, 70);
            this.labelShopperName.Name = "labelShopperName";
            this.labelShopperName.Size = new System.Drawing.Size(75, 15);
            this.labelShopperName.TabIndex = 6;
            this.labelShopperName.Text = "Shopper: No shopper";
            // 
            // (shopper abbrev removed)
            // 
            // labelMoneyLabel
            // 
            this.labelMoneyLabel.AutoSize = true;
            this.labelMoneyLabel.Location = new System.Drawing.Point(12, 90);
            this.labelMoneyLabel.Name = "labelMoneyLabel";
            this.labelMoneyLabel.Size = new System.Drawing.Size(41, 15);
            this.labelMoneyLabel.TabIndex = 7;
            this.labelMoneyLabel.Text = "Money:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(80, 90);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(34, 15);
            this.labelMoney.TabIndex = 8;
            this.labelMoney.Text = "$0.00";
            // 
            // listBoxOwned
            // 
            this.listBoxOwned.FormattingEnabled = true;
            this.listBoxOwned.ItemHeight = 15;
            this.listBoxOwned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOwned.Name = "listBoxOwned";
            this.listBoxOwned.TabIndex = 9;
            // 
            // CarLotForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 400);
            // configure split container
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Size = new System.Drawing.Size(900, 376);
            this.splitContainerMain.SplitterDistance = 600;
            this.splitContainerMain.TabIndex = 20;
            // left panel: inventory and buttons
            this.splitContainerMain.Panel1.Controls.Add(this.listBoxInventory);
            // we will add a small panel for buttons at the top of panel1
            var panelButtons = new System.Windows.Forms.Panel();
            panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            panelButtons.Height = 44;
            panelButtons.Controls.Add(this.buttonViewDetails);
            panelButtons.Controls.Add(this.buttonPurchase);
            this.splitContainerMain.Panel1.Controls.Add(panelButtons);
            // right panel: shopper info and owned list
            var panelShopperTop = new System.Windows.Forms.Panel();
            panelShopperTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelShopperTop.Height = 110;
            panelShopperTop.Controls.Add(this.textBoxShopperName);
            panelShopperTop.Controls.Add(this.numericUpDownMoney);
            panelShopperTop.Controls.Add(this.buttonCreateShopper);
            panelShopperTop.Controls.Add(this.labelShopperNameLabel);
            panelShopperTop.Controls.Add(this.labelShopperName);
            panelShopperTop.Controls.Add(this.labelMoneyLabel);
            panelShopperTop.Controls.Add(this.labelMoney);
            this.splitContainerMain.Panel2.Controls.Add(panelShopperTop);
            // owned list fills remaining space in panel2
            this.splitContainerMain.Panel2.Controls.Add(this.listBoxOwned);

            // add controls to form
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStrip1);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "CarLotForm";
            this.Text = "Car Lot";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
