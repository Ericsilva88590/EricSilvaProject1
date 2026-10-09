using System;
using System.Collections.Generic;

namespace Model
{
    public class Shopper
    {
        // Public properties
        public string Name { get; }
        public decimal MoneyAvailable { get; private set; }

        // Private data member
        private readonly List<Car> _cars;

        // Constructor
        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name must be provided.", nameof(name));
            if (moneyAvailable < 0m)
                throw new ArgumentOutOfRangeException(nameof(moneyAvailable), "MoneyAvailable cannot be negative.");

            Name = name;
            MoneyAvailable = decimal.Round(moneyAvailable, 2);
            _cars = new List<Car>();
        }

        // CanPurchase: returns true if shopper has enough money for totalCost
        public bool CanPurchase(decimal totalCost)
        {
            if (totalCost < 0m)
                throw new ArgumentOutOfRangeException(nameof(totalCost), "Total cost cannot be negative.");

            return MoneyAvailable >= totalCost;
        }

        // PurchaseCar: add car to shopper's list and deduct cost
        public void PurchaseCar(Car car, decimal totalCost)
        {
            if (car is null)
                throw new ArgumentNullException(nameof(car));
            if (totalCost < 0m)
                throw new ArgumentOutOfRangeException(nameof(totalCost), "Total cost cannot be negative.");
            if (totalCost > MoneyAvailable)
                throw new InvalidOperationException("Shopper does not have enough money to complete the purchase.");

            _cars.Add(car);
            MoneyAvailable = decimal.Round(MoneyAvailable - totalCost, 2);
        }

        // Expose shopper's cars as a read-only list
        public IReadOnlyList<Car> Cars => _cars.AsReadOnly();
    }
}
