using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter
{
    internal class ConverterMethods
    {
        public static void SumToUS(double sum)
        {
            const double currentValue = 0.084;
            var result = sum / currentValue;
            Console.WriteLine($"Sum Dollarda: ${result}");
        }

        public static void UsToSum(double us)
        {
            const double currentValue = 11400;
            var result = us * currentValue;
            Console.WriteLine($"Dollar sumda: {result}");
        }

        public static void EuroToUs(double us)
        {
            const double currentValue = 0.92;
            var result = us / currentValue;
            Console.WriteLine($"Euro dollarda: {result}");
        }
    }
}
