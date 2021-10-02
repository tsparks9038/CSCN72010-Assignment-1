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
            convertFrom = ModifyInput(convertFrom);
            convertTo = ModifyInput(convertTo);

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

        private static string ModifyInput(string input)
        {
            if (string.Equals(input, "metres") || string.Equals(input, "Metres") || string.Equals(input, "m") || string.Equals(input, "M"))
            {
                return "m";
            }

            else if (string.Equals(input, "yards") || string.Equals(input, "Yards") || string.Equals(input, "y") || string.Equals(input, "Y"))
            {
                return "y";
            }

            else if (string.Equals(input, "feet") || string.Equals(input, "Feet") || string.Equals(input, "f") || string.Equals(input, "F"))
            {
                return "f";
            }

            else if (string.Equals(input, "rods") || string.Equals(input, "Rods") || string.Equals(input, "r") || string.Equals(input, "R"))
            {
                return "r";
            }

            else
            {
                throw new ArgumentException("Incorrect unit", input);
            }
        }

        private static double GetMultiplierStub()
        {
            Console.WriteLine("GetMultiplierStub returns 2");

            return 2;
        }
    }
}
