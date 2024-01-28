﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VengoVE.Sprint4.Task0.V25.Lib
{
    public class DataService : ISprint4Task0V25
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
