using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i += 4)
            {
                // 1 = 1, 5 = 101, 9 = 1001 in binary
                Console.WriteLine(Convert.ToString(i, 2));
            }
        }
    }
}
