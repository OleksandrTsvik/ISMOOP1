using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Date startDate = new Date(2000, 1, 8, 2, 0);
            Airplane airplane = new Airplane("Kyiv", "Zhytomyr", startDate, new Date(2000, 1, 12, 20, 25));
            string startCity = airplane.GetStartCity();
            startDate.SetDay(12);
            airplane.GetInfo();

            Console.WriteLine($"Сумарний час подорожі у хвилинах: {airplane.GetTotalTime()}");
            if (airplane.IsArrivingToday())
                Console.WriteLine("Відправлення і прибуття відбудеться в той же день.");
            else Console.WriteLine("Прибуття не відбудеться в той же день, що і відправлення.");


            Product product = new Product();
            product.SetCost(new Currency("USD", 28.15));
            product.SetName("Pencil");
            product.GetInfo();

            Console.WriteLine($"Ціна одиниці товару в гривнях: {product.GetPriceInUAH()}");
            Console.WriteLine($"Загальна вартість усіх наявних на складі товарів: {product.GetTotalPriceInUAH()} UAH");
            Console.WriteLine($"Загальна вага усіх товарів на складі: {product.GetTotalWeight()} кг\n");
        }
    }
}
