using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class ProgramExecute
    {
        public void Execute()
        {
            TuitionCalculator tuition = new TuitionCalculator();
            Console.WriteLine("Please input the number of years for Tuition");
            tuition.CalculateTuition(int.Parse(Console.ReadLine()));
            Update();

            FeetToInches inches = new FeetToInches();
            Console.WriteLine("Please input a value for feet");
            inches.Inches(double.Parse(Console.ReadLine()));
            Update();

            GreaterThan greaterThan = new GreaterThan();
            Console.WriteLine("Please provide a value for X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide a value for Y");
            int y = int.Parse(Console.ReadLine());
            greaterThan.Find(x, y);
            Update();
        }
        private void Update()
        {
            Console.WriteLine("Program Complete Stepping into the next program");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
