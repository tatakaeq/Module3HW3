using System;

namespace Module3HW3
{
    public class Class1
    {
        public Action<bool> Action { get; set; }

        public double Pow(double x, double y)
        {
            return x * y;
        }
    }
}