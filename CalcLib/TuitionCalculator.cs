using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class TuitionCalculator
    {
        private double BaseInterest = 0.02;

        public void CalculateTuition(int years)
        {
            double Total = 6000;
            Console.WriteLine($"For the First year the Tuition will be {Total:c}");
            for (int i = 0; i < years - 1; i++)
            {
                Total += Total * BaseInterest;
                Console.WriteLine($"For {i + 2} years, Tuition will be {Total:c}");
            }
        }
    }
}
