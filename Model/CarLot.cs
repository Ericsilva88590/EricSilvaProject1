using System;
using System.Collections.Generic;

namespace Model
{
    public class CarLot
    {
        // private data member as required
        private List<Car> Inventory;

        // public constant tax rate 7.8%
        public const decimal TaxRate = 0.078m;

        // default constructor
        public CarLot()
        {
            Inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        // private helper to populate default inventory
        private void StockLotWithDefaultInventory()
        {
            Inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
            Inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19m, 65401.23m));
            Inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780m));
            Inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
        }

        // public method to find cars by make (case-insensitive)
        public List<Car>? FindCarsByMake(string make)
        {
            if (string.IsNullOrWhiteSpace(make))
                return null;

            var results = new List<Car>();

            foreach (var car in Inventory)
            {
                if (string.Equals(car.Make, make, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(car);
                }
            }

            return results.Count > 0 ? results : null;
        }
    }
}
