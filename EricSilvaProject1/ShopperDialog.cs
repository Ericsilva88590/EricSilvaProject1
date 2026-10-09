using System;
using System.Windows.Forms;
using Model;

namespace EricSilvaProject1
{
    public partial class ShopperDialog : Form
    {
        public ShopperDialog()
        {
            InitializeComponent();
        }

        public Shopper? Shopper { get; private set; }

        private void buttonOk_Click(object? sender, EventArgs e)
        {
            try
            {
                var name = textBoxName.Text.Trim();
                var money = numericUpDownMoney.Value;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (money < 0)
                {
                    MessageBox.Show("Money cannot be negative.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Shopper = new Shopper(name, money);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
