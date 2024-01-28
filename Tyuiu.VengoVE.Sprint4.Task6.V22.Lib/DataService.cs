using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VengoVE.Sprint4.Task6.V22.Lib
{
    public class DataService : ISprint4Task6V22
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, weather => weather.Length == 4);
            Console.WriteLine("Элементы массива, длина которых равна 4 символам:");
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
            return mas.Length;
        }
    }
}
