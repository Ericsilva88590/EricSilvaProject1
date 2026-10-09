using System;
using System.Windows.Forms;
using Model;

namespace EricSilvaProject1
{
    public partial class CarLotForm : Form
    {
        private readonly CarLot _carLot;
        private Shopper? _shopper;

        public CarLotForm()
        {
            InitializeComponent();

            // Initialize CarLot which will be stocked by default in its constructor
            _carLot = new CarLot();

            // Refresh UI
            RefreshInventoryList();
        }

        private void addCarToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            using var dlg = new AddCarForm();
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.NewCar != null)
            {
                _carLot.AddCar(dlg.NewCar.Make, dlg.NewCar.Model, dlg.NewCar.Mpg, dlg.NewCar.Price);
                RefreshInventoryList();
                MessageBox.Show("Car added to inventory.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshInventoryList()
        {
            listBoxInventory.Items.Clear();
            foreach (var car in _carLot.Inventory)
            {
                listBoxInventory.Items.Add(FormatCarDisplay(car));
            }
        }

        private void RefreshShopperInfo()
        {
            if (_shopper == null)
            {
                labelShopperName.Text = "No shopper";
                labelMoney.Text = "$0.00";
                listBoxOwned.Items.Clear();
                return;
            }

            labelShopperName.Text = _shopper.Name;
            labelMoney.Text = _shopper.MoneyAvailable.ToString("C2");

            listBoxOwned.Items.Clear();
            foreach (var car in _shopper.Cars)
            {
                listBoxOwned.Items.Add(FormatCarDisplay(car));
            }
        }

        private static string FormatCarDisplay(Car car)
        {
            return $"{car.Make} {car.Model} - {car.Mpg:N2} MPG - {car.Price:C2}";
        }

        private void buttonCreateShopper_Click(object? sender, EventArgs e)
        {
            using var dlg = new ShopperDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Shopper != null)
            {
                _shopper = dlg.Shopper;
                // populate optional fields
                textBoxShopperName.Text = _shopper.Name;
                numericUpDownMoney.Value = _shopper.MoneyAvailable;
                RefreshShopperInfo();
                MessageBox.Show("Shopper created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPurchase_Click(object? sender, EventArgs e)
        {
            if (_shopper == null)
            {
                MessageBox.Show("Create a shopper first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var index = listBoxInventory.SelectedIndex;
            if (index < 0 || index >= _carLot.Inventory.Count)
            {
                MessageBox.Show("Select a car from the inventory.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var car = _carLot.Inventory[index];
            var total = _carLot.GetTotalCostOfPurchase(car);

            if (!_shopper.CanPurchase(total))
            {
                MessageBox.Show($"Shopper cannot afford the car. Total: {total:C2}", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with purchase
            var purchased = _carLot.PurchaseCar(car.Make, car.Model);
            if (purchased == null)
            {
                MessageBox.Show("Car no longer available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshInventoryList();
                return;
            }

            _shopper.PurchaseCar(purchased, total);
            MessageBox.Show($"Purchase complete. Total: {total:C2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshInventoryList();
            RefreshShopperInfo();
        }
    }
}
