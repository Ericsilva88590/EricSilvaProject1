namespace EricSilvaProject1
{
    partial class AddCarForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelMpg;
        private System.Windows.Forms.NumericUpDown numericUpDownMpg;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMake = new System.Windows.Forms.Label();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelMpg = new System.Windows.Forms.Label();
            this.numericUpDownMpg = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMpg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(12, 9);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(36, 15);
            this.labelMake.TabIndex = 0;
            this.labelMake.Text = "Make:";
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(80, 6);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(200, 23);
            this.textBoxMake.TabIndex = 1;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 38);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(42, 15);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "Model:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(80, 35);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(200, 23);
            this.textBoxModel.TabIndex = 3;
            // 
            // labelMpg
            // 
            this.labelMpg.AutoSize = true;
            this.labelMpg.Location = new System.Drawing.Point(12, 67);
            this.labelMpg.Name = "labelMpg";
            this.labelMpg.Size = new System.Drawing.Size(36, 15);
            this.labelMpg.TabIndex = 4;
            this.labelMpg.Text = "MPG:";
            // 
            // numericUpDownMpg
            // 
            this.numericUpDownMpg.DecimalPlaces = 2;
            this.numericUpDownMpg.Location = new System.Drawing.Point(80, 65);
            this.numericUpDownMpg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMpg.Name = "numericUpDownMpg";
            this.numericUpDownMpg.Size = new System.Drawing.Size(200, 23);
            this.numericUpDownMpg.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 97);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 15);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price:";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(80, 95);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 23);
            this.numericUpDownPrice.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(80, 130);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(90, 30);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(190, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddCarForm
            // 
            this.ClientSize = new System.Drawing.Size(294, 172);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDownMpg);
            this.Controls.Add(this.labelMpg);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.labelMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCarForm";
            this.Text = "Add Car";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMpg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
