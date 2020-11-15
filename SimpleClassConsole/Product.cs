using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    public class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight; // вага одиниці товару в кг

        public Product()
        {
            SetName("Pen");
            SetPrice(3.00);
            SetCost(new Currency("грн.", 1.00));
            SetQuantity(1000);
            SetProducer("Buromax");
            SetWeight(0.02);
        }

        public Product(string name, double price)
        {
            SetName(name);
            SetPrice(price);
            SetCost(new Currency("грн.", 1.00));
            SetQuantity(1000);
            SetProducer("Buromax");
            SetWeight(0.02);
        }

        public Product(int quantity, string producer, double weight)
        {
            SetName("Pen");
            SetPrice(3.00);
            SetCost(new Currency("грн.", 1.00));
            SetQuantity(quantity);
            SetProducer(producer);
            SetWeight(weight);
        }

        public Product(Currency cost)
        {
            SetName("Pen");
            SetPrice(3.00);
            SetCost(cost);
            SetQuantity(1000);
            SetProducer("Buromax");
            SetWeight(0.02);
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            SetName(name);
            SetPrice(price);
            SetCost(cost);
            SetQuantity(quantity);
            SetProducer(producer);
            SetWeight(weight);
        }

        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = obj.Cost;
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }

        public void SetName(string name)
        {
            Regex regex = new Regex(@"\b([АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ][абвгґдеєжзиіїйклмнопрстуфхцчшщьюя]+|[A-Z][a-z]+)\b");
            MatchCollection str = regex.Matches(name);
            if (name.Length > 0 && str.Count == 1)
                Name = name;
            else Name = "Unknown";
        }

        public void SetPrice(double price)
        {
            if (price > 0)
                Price = price;
            else Price = 0;
        }

        public void SetCost(Currency cost)
        {
            Cost = cost;
        }

        public void SetQuantity(int quantity)
        {
            if (quantity > 0)
                Quantity = quantity;
            else Quantity = 0;
        }

        public void SetProducer(string producer)
        {
            Regex regex = new Regex(@"\b([АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ][абвгґдеєжзиіїйклмнопрстуфхцчшщьюя]+|[A-Z][a-z]+)\b");
            MatchCollection str = regex.Matches(producer);
            if (producer.Length > 0 && str.Count == 1)
                Producer = producer;
            else Producer = "Unknown";
        }

        public void SetWeight(double weight)
        {
            if (weight > 0)
                Weight = weight;
            else Weight = 0;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public Currency GetCost()
        {
            return Cost;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public string GetProducer()
        {
            return Producer;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public double GetPriceInUAH()
        {
            double price = GetPrice() * GetCost().GetExRate();
            return price;
        }

        public double GetTotalPriceInUAH()
        {
            double price = GetPriceInUAH() * GetQuantity();
            return price;
        }

        public double GetTotalWeight()
        {
            double weight = GetWeight() * GetQuantity();
            return weight;
        }

        public void GetInfo()
        {
            Console.WriteLine("\n\n\tProduct");

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price} {Cost.GetName()}");
            Console.WriteLine($"Cost: 1 {Cost.GetName()} --> {Cost.GetExRate()} UAH");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Producer: {Producer}");
            Console.WriteLine($"Weight: {Weight} кг\n");
        }
    }
}
