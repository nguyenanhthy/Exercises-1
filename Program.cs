using System.Transactions;

internal class Exercise1
{
    private static void Main()
    {
        // Question_01();
        // Question_02();
        // Question_03();
        // Question_04();
        // Question_05();
        // Question_06();
        // Question_07();
        // Question_08();
        // Question_09();
        // Question_10();

        Console.WriteLine("Press any key to stop");
        Console.ReadKey();
    }
    /// <summary>
    /// 1. to Add / Sum Two Numbers
    /// </summary>
    public static void Question_01()
    {
        Console.Write("Enter a number a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a number b= ");
        int b= int.Parse(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine($"sum of: {a} + {b} = {sum}");
    }
    /// <summary>
    /// 2. to Swap Values of Two Variables
    /// </summary>
    public static void Question_02()
    {
        Console.Write("Enter a number a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a number b= ");
        int b = int.Parse(Console.ReadLine());
        int c = a;
        a = b; b = c;
        Console.WriteLine($" Now, a = {a}; b = {b} ");
    }
    /// <summary>
    /// 3. to Multiply two Floating Point Numbers
    /// </summary>
    public static void Question_03()
    {
        Console.Write("Enter a number a= ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter a number b= ");
        float b = float.Parse(Console.ReadLine());
        float product= a * b;
        Console.WriteLine( $"Product of: {a} * {b} = {product}" );

    }
    /// <summary>
    /// 4. to convert feet to meter
    /// </summary>
    public static void Question_04()
    {
        double feet, meter;
        Console.Write("Input feet: ");
        feet=Convert.ToDouble(Console.ReadLine());
        meter = feet / 3.2808399;
        Console.WriteLine($"convert {feet} to meter = {meter}");

    }
    /// <summary>
    /// 5. to convert Celsius to Fahrenheit and vice versa
    /// </summary>
    public static void Question_05()
    {
        Console.Write("Which do you want to convert, Celcius or Fahrenheit:  ");
        string donvi = Console.ReadLine();
        if (donvi == "C")
        {
            Console.Write("Input Celcius: ");
            double nhietdoC = double.Parse(Console.ReadLine());
            double nhietdoF = nhietdoC * (9 / 5) + 32;
            Console.WriteLine($"{nhietdoC} Celcius convert to Fahrenheit = {nhietdoF}");
        }
        else 
        {
            Console.Write("Input Fahrenheit: ");
            double nhietdoF = double.Parse(Console.ReadLine());
            double nhietdoC = (nhietdoF - 32) * 5 / 9;
            Console.WriteLine($"{nhietdoF} Fahrenheit convert to Celcius = {nhietdoC}");
        }       
        
    }
    /// <summary>
    /// 6. to find the Size of data types
    /// </summary>
    public static void Question_06()
    {
        Console.WriteLine($"sizeof(int):{sizeof(int)}");
        Console.WriteLine($"sizeof(float):{sizeof(float)}");
        Console.WriteLine($"sizeof(char):{sizeof(char)}");
        Console.WriteLine($"sizeof(double):{sizeof(double)}");
        Console.WriteLine($"sizeof(bool):{sizeof(bool)}");
    }
    /// <summary>    /// 7. to Print ASCII Value (tip: read character, print number of this char)
    /// </summary>
    public static void Question_07()
    {
        Console.Write("write a letter: ");
        Console.WriteLine($"Print ASCII Value {Console.Read()}");
    }
    /// <summary>
    /// 8. to Calculate Area of Circle
    /// </summary>
    public static void Question_08()
    {
        const double pi = 3.14159;
        Console.Write("Insert r = ");
        double r = double.Parse(Console.ReadLine());
        double S = r * r * pi;
        Console.WriteLine($"Area of Circle = {S}");
    }
    /// <summary>
    /// 9. to Calculate Area of Square
    /// </summary>
    public static void Question_09()
    {
        Console.Write("Insert length of a side: a = ");
        double a = double.Parse(Console.ReadLine());
        double S = a * a;
        Console.WriteLine($"Area of Aquae = {S}");
    }
    /// <summary>
    /// 10. to convert days to years, weeks and days
    /// </summary>
    public static void Question_10()
    {
        Console.Write("Insert days: ");
        int days = int.Parse(Console.ReadLine());
        int years = days / 365;
        int day_w = days - years * 365;
        int weeks = day_w / 7;
        int d = day_w % 7;
        Console.WriteLine($" = {years} Years {weeks} Weeks {d} Days ");
    }
}