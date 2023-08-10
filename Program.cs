namespace Temperaturberegneren
{
    internal class Program
    {
        static void Main()
        {
            // Waiting on input
            Console.Clear();
            Console.Write("Input a Celcius (°C) value: ");
            string Input = Console.ReadLine()!;

            // If input can be parsed to double
            if (double.TryParse(Input, out double Celcius))
            {
                double Fahrenheit = (Celcius * 1.8) + 32;
                double Reamur = Celcius * 0.8;

                Console.Clear();
                Console.WriteLine($"{Celcius}°C in Fahrenheit is {Fahrenheit}°F, and in Reamur, it's {Reamur}°Ré.");
                Console.ReadKey();
                Main();
            }
            // Otherwise inform the value cannot be parsed, and return to input
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid value.");
                Console.ReadKey();
                Main();
            }
        }
    }
}