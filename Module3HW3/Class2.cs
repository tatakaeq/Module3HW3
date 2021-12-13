using System;

namespace Module3HW3
{
    public class Class2
    {
        private double _powResult;

        public Func<double, bool> Calc(Func<double, double, double> powResultHandler, double x, double y)
        {
            _powResult = powResultHandler(x, y);
            Func<double, bool> resultHandler = Result;
            return resultHandler;
        }

        public bool Result(double x)
        {
            return _powResult % x == 0;
        }
    }
}