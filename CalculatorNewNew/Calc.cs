using System;

namespace CalculatorNewNew
{

    public class Calc
    {
        public double Accumulator { get; private set; }

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
        //Ny tilføjet metode nr. 2
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            return (a / b);
        }
        //Ny tilføjet metode
        public double AddAccumulator(double a)
        {
            return Accumulator += a;
            // Property Accumulator tillægges værdien fra parameter a. 
        }
    }
}
