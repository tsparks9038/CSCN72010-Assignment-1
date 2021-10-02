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
                multiplier = GetMultiplier(convertFrom, convertTo);
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


        private static double GetMultiplier(string convertFrom, string convertTo)
        {
            if (convertFrom == "m")
            {
                if (convertTo == "y")
                {
                    return 1.09361;
                }

                else if (convertTo == "f")
                {
                    return 3.28084;
                }

                else
                {
                    return 0.198839;
                }
            }

            else if (convertFrom == "y")
            {
                if (convertTo == "m")
                {
                    return 0.9144;
                }

                else if (convertTo == "f")
                {
                    return 3;
                }

                else
                {
                    return 0.181818;
                }
            }

            else if (convertFrom == "f")
            {
                if (convertTo == "m")
                {
                    return 0.3048;
                }

                else if (convertTo == "y")
                {
                    return 0.333333;
                }

                else
                {
                    return 0.0606061;
                }
            }

            else
            {
                if (convertTo == "m")
                {
                    return 5.0292;
                }

                else if (convertTo == "y")
                {
                    return 5.5;
                }

                else
                {
                    return 16.5;
                }
            }
        }
    }
}
