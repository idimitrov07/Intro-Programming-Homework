﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = -3;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(Convert.ToString(x) + ", " + Convert.ToString(y) + ", ");
                x = x + 2;
                y = y - 2;
            }
        }
    }
}
