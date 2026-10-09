using System;
using System.Windows.Forms;
using Model;

namespace EricSilvaProject1
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        public Car? NewCar { get; private set; }

        private void buttonOk_Click(object? sender, EventArgs e)
        {
            try
            {
                var make = textBoxMake.Text.Trim();
                var model = textBoxModel.Text.Trim();
                var mpg = numericUpDownMpg.Value;
                var price = numericUpDownPrice.Value;

                if (string.IsNullOrWhiteSpace(make))
                {
                    MessageBox.Show("Make is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(model))
                {
                    MessageBox.Show("Model is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (mpg <= 0)
                {
                    MessageBox.Show("MPG must be greater than 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (price < 0)
                {
                    MessageBox.Show("Price cannot be negative.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NewCar = new Car(make, model, mpg, price);
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
