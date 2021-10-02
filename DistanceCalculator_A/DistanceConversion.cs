using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculator_A
{
    public static class DistanceConversion
    {
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            convertFrom = ModifyInputStub(); //replace with stub
            convertTo = ModifyInputStub(); //replace with stub

            double multiplier;

            if (convertFrom == convertTo)
            {
                multiplier = 1;
            }

            else
            {
                multiplier = GetMultiplierStub();
            }

            return value * multiplier;
        }

        private static string ModifyInputStub()
        {
            Console.WriteLine("ModifyInputStub returns m");

            return "m";
        }

        private static double GetMultiplierStub()
        {
            Console.WriteLine("GetMultiplierStub returns 2");

            return 2;
        }
    }
}
