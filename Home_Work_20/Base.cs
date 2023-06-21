using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoneyConverter.Delegates;

namespace MoneyConverter
{
    internal class Main
    {
        public static void BankService(float money ,MoneyConverters converters)
        {
            converters(money);

        }
    }
}
