using System;

namespace ExceptionHandling
{
    public class Calculator
    {
        public int Divide(int numerator, int denomenator)
        {
            try
            {
                return numerator / denomenator;
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Cannot divide by zero");
                return 0;
            }

        }
    }
}