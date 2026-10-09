using System;

namespace Model
{
    public class Car
    {
        public string Make { get; }
        public string Model { get; }
        public decimal Mpg { get; }
        public decimal Price { get; }

        public Car(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Make cannot be null or empty.", nameof(make));

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Model cannot be null or empty.", nameof(model));

            if (mpg <= 0m)
                throw new ArgumentOutOfRangeException(nameof(mpg), "Mpg must be greater than 0.");

            if (mpg > 1000m)
                throw new ArgumentOutOfRangeException(nameof(mpg), "Mpg value is unreasonably large.");

            if (price < 0m)
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");

            Make = make;
            Model = model;
            Mpg = decimal.Round(mpg, 2);
            Price = decimal.Round(price, 2);
        }
    }
}
