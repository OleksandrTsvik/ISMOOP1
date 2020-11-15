using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    public class Currency
    {
        protected string Name;
        protected double ExRate;

        public Currency()
        {
            SetName("USD");
            SetExRate(28.15);
        }

        public Currency(string name)
        {
            SetName(name);
            SetExRate(28.15);
        }

        public Currency(double exRate)
        {
            SetName("USD");
            SetExRate(exRate);
        }

        public Currency(string name, double exRate)
        {
            SetName(name);
            SetExRate(exRate);
        }

        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }

        public void SetName(string name)
        {
            Regex regex = new Regex(@"\b([АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ]+|[абвгґдеєжзиіїйклмнопрстуфхцчшщьюя]+|[A-Z]+|[a-z]+)\.?\b");
            MatchCollection str = regex.Matches(name);
            if (name.Length > 0 && str.Count == 1)
                Name = name;
            else Name = "Unknown";
        }

        public void SetExRate(double exRate)
        {
            if (exRate > 0)
                ExRate = exRate;
            else ExRate = 0;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetExRate()
        {
            return ExRate;
        }
    }
}
