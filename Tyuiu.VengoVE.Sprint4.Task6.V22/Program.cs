using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VengoVE.Sprint4.Task6.V22.Lib;

namespace Tyuiu.VengoVE.Sprint4.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Вэнго В. Э. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Вэнго В. Э. | ИСПб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Снег, Дождь, Туман, Град, Ветер, Туча,     *");
            Console.WriteLine("* Засуха], используя класс Array, выведите элементы массива,              *");
            Console.WriteLine("* длина которых равна 4 символам.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var weather = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < weather.Length; i++)
            {
                Console.WriteLine(weather[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длина которых равна = 4");

            int nums = ds.Calculate(weather);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
