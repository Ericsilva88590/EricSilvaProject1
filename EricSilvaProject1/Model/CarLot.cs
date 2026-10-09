using System;
using System.Collections.Generic;

namespace Model
{
    public class CarLot
    {
        // private data member as required
        private readonly List<Car> _inventory;

        // public constant tax rate 7.8%
        public const decimal TaxRate = 0.078m;

        // default constructor
        public CarLot()
        {
            _inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        // private helper to populate default inventory
        private void StockLotWithDefaultInventory()
        {
            _inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
            _inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19m, 65401.23m));
            _inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780m));
            _inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
        }

        // public method to find cars by make (case-insensitive)
        public List<Car> FindCarsByMake(string make)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make must be provided.", nameof(make));

            var results = new List<Car>();

            foreach (var car in _inventory)
            {
                if (string.Equals(car.Make, make, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(car);
                }
            }

            return results.Count > 0 ? results : null!;
        }

        // find first car by make and model (case-insensitive)
        public Car? FindCarByMakeModel(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make must be provided.", nameof(make));
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model must be provided.", nameof(model));

            foreach (var car in _inventory)
            {
                if (string.Equals(car.Make, make, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(car.Model, model, StringComparison.OrdinalIgnoreCase))
                {
                    return car;
                }
            }

            return null;
        }

        // purchase car: remove from inventory and return it
        public Car? PurchaseCar(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make must be provided.", nameof(make));
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model must be provided.", nameof(model));

            for (int i = 0; i < _inventory.Count; i++)
            {
                var car = _inventory[i];
                if (string.Equals(car.Make, make, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(car.Model, model, StringComparison.OrdinalIgnoreCase))
                {
                    _inventory.RemoveAt(i);
                    return car;
                }
            }

            return null;
        }

        // add a new car to inventory
        public void AddCar(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make must be provided.", nameof(make));
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model must be provided.", nameof(model));
            if (mpg <= 0m)
                throw new ArgumentOutOfRangeException(nameof(mpg), "Mpg must be greater than 0.");
            if (price < 0m)
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");

            var car = new Car(make, model, mpg, price);
            _inventory.Add(car);
        }

        // calculate total cost including tax
        public decimal GetTotalCostOfPurchase(Car car)
        {
            if (car is null)
                throw new ArgumentNullException(nameof(car));

            return decimal.Round(car.Price + (car.Price * TaxRate), 2);
        }

        // find least expensive car
        public Car? FindLeastExpensiveCar()
        {
            if (_inventory.Count == 0)
                return null;

            Car? cheapest = null;
            foreach (var car in _inventory)
            {
                if (cheapest == null || car.Price < cheapest.Price)
                    cheapest = car;
            }

            return cheapest;
        }

        // find most expensive car
        public Car? FindMostExpensiveCar()
        {
            if (_inventory.Count == 0)
                return null;

            Car? priciest = null;
            foreach (var car in _inventory)
            {
                if (priciest == null || car.Price > priciest.Price)
                    priciest = car;
            }

            return priciest;
        }

        // find best MPG car
        public Car? FindBestMPGCar()
        {
            if (_inventory.Count == 0)
                return null;

            Car? best = null;
            foreach (var car in _inventory)
            {
                if (best == null || car.Mpg > best.Mpg)
                    best = car;
            }

            return best;
        }

        // find worst MPG car
        public Car? FindWorstMPG()
        {
            if (_inventory.Count == 0)
                return null;

            Car? worst = null;
            foreach (var car in _inventory)
            {
                if (worst == null || car.Mpg < worst.Mpg)
                    worst = car;
            }

            return worst;
        }

        // Count expression-bodied property
        public int Count => _inventory.Count;

        // Inventory expression-bodied property
        public List<Car> Inventory => _inventory;
    }
}
