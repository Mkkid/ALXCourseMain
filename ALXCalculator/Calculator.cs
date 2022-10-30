using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Running calculator");
            Console.Write("X number:");
            var x = Console.ReadLine();

            var xInt=Double.Parse(x);
            Console.Write("Ynumber");
            var y = Console.ReadLine();
            var yInt=Double.Parse(y);
            Console.WriteLine($"{x} + {y} = {Add(xInt,yInt)}");
            Console.WriteLine($"{x} - {y} = {Substract(xInt,yInt)}");
            Console.WriteLine($"{x} * {y} = {Multiply(xInt,yInt)}");
            Console.WriteLine($"{x} / {y} = {Divide(xInt,yInt)}");
        }
        private double Add(double x, double y)
        {
            return x + y;
        }
        private double Substract(double x, double y)
        {
            return x - y;
        }

        private double Divide(double x, double y)
        {
            return x / y;
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }


    }
}
