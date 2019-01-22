using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class GreaterThan
    {
        public void Find(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else
            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            else
            {
                Console.WriteLine($"{y} is greater than {x}");
            }
        }
    }
}
