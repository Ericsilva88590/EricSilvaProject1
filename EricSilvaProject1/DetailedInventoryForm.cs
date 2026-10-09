using System;
using System.Text;
using System.Windows.Forms;
using Model;

namespace EricSilvaProject1
{
    public partial class DetailedInventoryForm : Form
    {
        private readonly CarLot _carLot;

        public DetailedInventoryForm(CarLot carLot)
        {
            InitializeComponent();
            _carLot = carLot ?? throw new ArgumentNullException(nameof(carLot));
            LoadDetails();
        }

        private void LoadDetails()
        {
            var sb = new StringBuilder();
            var inventory = _carLot.Inventory;
            sb.AppendLine($"Inventory of {inventory.Count} cars.");
            foreach (var car in inventory)
            {
                sb.AppendLine($"{car.Make} {car.Model} {car.Price:C2} {car.Mpg:F1}mpg");
            }
            sb.AppendLine();

            var most = _carLot.FindMostExpensiveCar();
            if (most != null)
            {
                sb.AppendLine("Most expensive:");
                sb.AppendLine($"{most.Make} {most.Model} {most.Price:C2} {most.Mpg:F1}mpg");
            }
            var least = _carLot.FindLeastExpensiveCar();
            if (least != null)
            {
                sb.AppendLine();
                sb.AppendLine("Least expensive:");
                sb.AppendLine($"{least.Make} {least.Model} {least.Price:C2} {least.Mpg:F1}mpg");
            }
            var best = _carLot.FindBestMPGCar();
            if (best != null)
            {
                sb.AppendLine();
                sb.AppendLine("Best MPG:");
                sb.AppendLine($"{best.Make} {best.Model} {best.Price:C2} {best.Mpg:F1}mpg");
            }
            var worst = _carLot.FindWorstMPG();
            if (worst != null)
            {
                sb.AppendLine();
                sb.AppendLine("Worst MPG:");
                sb.AppendLine($"{worst.Make} {worst.Model} {worst.Price:C2} {worst.Mpg:F1}mpg");
            }

            textBoxDetails.Text = sb.ToString();
        }

        private void buttonClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
