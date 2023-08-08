using System;

namespace ValorerEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;
            double doubleMaxValue = double.MaxValue;
            double doubleMinValue = double.MinValue;
            float floatMaxValue = float.MaxValue;
            float floatMinValue = float.MinValue;
            double positiveInfinite = double. PositiveInfinity;
            double negativeInfinite = double. NegativeInfinity;
            float nan = float.NaN;
            int result = intMaxValue + 1;
            double overflow = 2 * double.MaxValue;
            float underflow1, underflow2;
            underflow1 = underflow2 = 10000.0F;

            Console.WriteLine(intMaxValue);
            Console.WriteLine(intMinValue);
            Console.WriteLine(doubleMaxValue);
            Console.WriteLine(doubleMinValue);
            Console.WriteLine(floatMaxValue);
            Console.WriteLine(floatMinValue);
            Console.WriteLine(positiveInfinite);
            Console.WriteLine(negativeInfinite);
            Console.WriteLine(nan);
            Console.WriteLine(result);
            Console.WriteLine(overflow);
            Console.WriteLine(underflow1 == underflow2 + 0.00000001F);
        }
    }
}
