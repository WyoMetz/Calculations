using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class FeetToInches
    {
        public void Inches(double feet)
        {
            double TotalInches = feet * 12;
            Console.WriteLine($"There are {TotalInches} inches in {feet} Feet");
        }
    }
}
