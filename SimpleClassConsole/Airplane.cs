using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        public Airplane() // конструктор по замовчуванню
        {
            SetStartCity("Unknown");
            SetFinishCity("Unknown");
            SetStartDate(new Date(2000, 1, 1, 0, 0));
            SetFinishDate(new Date(2000, 2, 1, 0, 0));
        }

        public Airplane(string startCity) // конструктор з параметрами
        {
            SetStartCity(startCity);
            SetFinishCity("Unknown");
            SetStartDate(new Date(2000, 1, 1, 0, 0));
            SetFinishDate(new Date(2000, 2, 1, 0, 0));
        }

        public Airplane(string startCity, string finishCity) // конструктор з параметрами
        {
            SetStartCity(startCity);
            SetFinishCity(finishCity);
            SetStartDate(new Date(2000, 1, 1, 0, 0));
            SetFinishDate(new Date(2000, 2, 1, 0, 0));
        }

        public Airplane(string startCity, string finishCity, Date startDate) // конструктор з параметрами
        {
            SetStartCity(startCity);
            SetFinishCity(finishCity);
            SetStartDate(startDate);
            SetFinishDate(new Date(2000, 2, 1, 0, 0));
        }

        public Airplane(string startCity, string finishCity, Date startDate, Date finishDate) // конструктор з параметрами
        {
            SetStartCity(startCity);
            SetFinishCity(finishCity);
            SetStartDate(startDate);
            SetFinishDate(finishDate);
        }

        public Airplane(Airplane obj) // конструктор копіювання
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = obj.StartDate;
            FinishDate = obj.FinishDate;
        }

        public void SetStartCity(string startCity)
        {
            Regex regex = new Regex(@"\b([АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ][абвгґдеєжзиіїйклмнопрстуфхцчшщьюя]+|[A-Z][a-z]+)\b");
            MatchCollection str = regex.Matches(startCity);
            if (startCity.Length > 0 && str.Count == 1)
                StartCity = startCity;
            else StartCity = "Unknown";
        }

        public void SetFinishCity(string finishCity)
        {
            Regex regex = new Regex(@"\b([АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ][абвгґдеєжзиіїйклмнопрстуфхцчшщьюя]+|[A-Z][a-z]+)\b");
            MatchCollection str = regex.Matches(finishCity);
            if (finishCity.Length > 0 && str.Count == 1)
                FinishCity = finishCity;
            else FinishCity = "Unknown";
        }

        public void SetStartDate(Date startDate)
        {
            StartDate = startDate;
        }

        public void SetFinishDate(Date finishDate)
        {
            FinishDate = finishDate;
        }

        public string GetStartCity()
        {
            return StartCity;
        }

        public string GetFinishCity()
        {
            return FinishCity;
        }

        public Date GetStartDate()
        {
            return StartDate;
        }

        public Date GetFinishDate()
        {
            return FinishDate;
        }

        public int GetTotalTime()
        {
            int totalTravelTimeMinutes = 0;
            totalTravelTimeMinutes += (FinishDate.GetYear() - StartDate.GetYear()) * 365 * 24 * 60;
            totalTravelTimeMinutes += (FinishDate.GetMonth() - StartDate.GetMonth()) * 31 * 24 * 60;
            totalTravelTimeMinutes += (FinishDate.GetDay() - StartDate.GetDay()) * 24 * 60;
            totalTravelTimeMinutes += (FinishDate.GetHours() - StartDate.GetHours()) * 60;
            totalTravelTimeMinutes += FinishDate.GetMinutes() - StartDate.GetMinutes();

            return totalTravelTimeMinutes;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.GetYear() == FinishDate.GetYear() && StartDate.GetMonth() == FinishDate.GetMonth() && StartDate.GetDay() == FinishDate.GetDay())
                return true;
            return false;
        }

        public void GetInfo()
        {
            Console.WriteLine("\tAirplane");

            Console.WriteLine($"Start: {StartCity}, {StartDate.GetYear()}.{AddZeroForOutput(StartDate.GetMonth())}.{AddZeroForOutput(StartDate.GetDay())} {AddZeroForOutput(StartDate.GetHours())}:{AddZeroForOutput(StartDate.GetMinutes())}");

            Console.WriteLine($"Finish: {FinishCity}, {FinishDate.GetYear()}.{AddZeroForOutput(FinishDate.GetMonth())}.{AddZeroForOutput(FinishDate.GetDay())} {AddZeroForOutput(FinishDate.GetHours())}:{AddZeroForOutput(FinishDate.GetMinutes())}\n");
        }

        private string AddZeroForOutput(int num)
        {
            string numAddZero = Convert.ToString(num);
            if (numAddZero.Length == 1)
                return '0' + numAddZero;
            return numAddZero;
        }
    }
}
