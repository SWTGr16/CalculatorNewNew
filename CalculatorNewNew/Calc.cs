using System;

namespace CalculatorNewNew
{
    public class Calc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
        //Ny tilføjet metode 
        public double AddAndSubtract(double a, double b, double c)
        {
            return (a + b - c);
        }
    }
}
