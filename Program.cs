internal class Program
{
    private static void Main()
    {
        // Question_01();
        // Question_02();
        // Question_03();
        // Question_04();
         Question_05();
        // Question_06();
        // Question_07();
        // Question_08();
        // Question_09();
        // Question_10();

        Console.WriteLine("Press enikey to stop");
        Console.ReadKey();
    }
    /// <summary>
    /// 1. to Add / Sum Two Numbers
    /// </summary>
    public static void Question_01()
    {
        Console.WriteLine("Enter a number a= ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number b= ");
        int b= int.Parse(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine($"sum of: {a} + {b} = {sum}");
    }
    /// <summary>
    /// 2. to Swap Values of Two Variables
    /// </summary>
    public static void Question_02()
    {
        Console.WriteLine("Enter a number a= ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number b= ");
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
        Console.WriteLine("Enter a number a= ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number b= ");
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
        Console.WriteLine("Input feet: ");
        feet=Convert.ToDouble(Console.ReadLine());
        meter = feet / 3.2808399;
        Console.WriteLine($"convert {feet} to meter = {meter}");

    }
    /// <summary>
    /// 5. to convert Celsius to Fahrenheit and vice versa
    /// </summary>
    public static void Question_05()
    {
        double celcius, fahrenheit;
        Console.WriteLine("Which do you want to convert, Celcius or Fahrenheit?);
        string donvi = Console.ReadLine());
        if (donvi == "C")
        {
            Console.WriteLine("Input Celcius: ");
            double celcius 
        }
        
        Console.WriteLine("Input Celcius = ");
        celcius = Convert.ToDouble(Console.ReadLine());
        fahrenheit = (celcius * 9) / 5 + 32 ; 
        Console.WriteLine($"convert {celcius} to Fahrenheit = {fahrenheit} ");

        Console.WriteLine("Input Fahrenheit = ");
        fahrenheit= Convert.ToDouble(Console.ReadLine());  
        celcius= (fahrenheit - 32 ) 
    }
    public static void Question_06()
    {

    }
    public static void Question_07()
    {

    }
    public static void Question_08()
    {

    }
    public static void Question_09()
    {

    }
    public static void Question_10()
    {

    }
}