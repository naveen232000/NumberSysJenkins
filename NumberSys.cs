﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNumbersys
{
    public class NumberSys
    {
       public  int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public  void OddNum()
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 1) { Console.WriteLine(num); }
            }
        }
        public  void EvenNum()
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 0) { Console.WriteLine(num); }
            }
        }
    }
}
