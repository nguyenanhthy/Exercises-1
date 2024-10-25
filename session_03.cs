
using System.Transactions;

namespace Exercises_2
{
    internal class session_02
    {
        private static void Main1()
        {
            // Question_01();
            // Question_02();
             Question_03();
        }
        /// <summary>
        /// 1. Convert from degrees Celsius to Kelvin and Fahrenheit
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter Celcius: ");
            int C = int.Parse(Console.ReadLine());
            int F = C * 9 / 5 + 32;
            int K = C + 273;
            Console.WriteLine($"Convert to Fahrenheit {F}");
            Console.WriteLine($"Convert to Fahrenheit {K}");
        }
        /// <summary>
        /// 2. Calculate the surface and volume of a sphere
        /// </summary>
        public static void Question_02()
        {
            Console.Write(" Enter Radius : ");
            float r = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r,2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r,3);
            Console.WriteLine($"Surface of sphene: {surface}");
            Console.WriteLine($"Volume of sphene: {volume}");
        }
        /// <summary>
        /// 3. Calculates the result of adding, subtracting, multiplying and dividing two numbers
        /// </summary>
        public static void Question_03() 
        {
            Console.WriteLine("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"Sum = {c}");
            int d = a - b;
            Console.WriteLine($"subtraction: {d}");
            int e = a * b;
            Console.WriteLine($"multiply:{e}");
            int f = a / b;
            Console.WriteLine($"division: {f}");
            int g = a % b;
            Console.WriteLine($"the rest of the division: {g}");

        }
    }
}
