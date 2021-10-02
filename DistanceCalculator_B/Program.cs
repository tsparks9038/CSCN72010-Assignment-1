using System;

namespace DistanceCalculator_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "y";

            while (loop == "y")
            {
                Console.WriteLine("Value: ");
                double value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Convert from: ");
                string convertFrom = Console.ReadLine();
                Console.WriteLine("Convert to: ");
                string convertTo = Console.ReadLine();

                try
                {
                    DistanceConversion.Convert(value, convertFrom, convertTo);
                }

                catch (ArgumentException e)
                {
                    Console.WriteLine("{0}: {1}\n", e.GetType().Name, e.Message);

                    Console.WriteLine("Continue? (y/n): ");
                    loop = Console.ReadLine();

                    continue;
                }

                value = DistanceConversion.Convert(value, convertFrom, convertTo);

                Console.WriteLine(value);

                Console.WriteLine("Continue? (y/n): ");
                loop = Console.ReadLine();
            }
        }
    }
}
