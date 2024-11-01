using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Exercises_1
{
    internal class session04_01
    {
        private static void Main1()
        {
            //Question01();
            //Question02();
            //Question03();
            //Question04();
            //Question05();
            Console.WriteLine( "Press any key to continue");
            Console.ReadKey();
        }

        /// <summary>
        /// 1.  Write a C# Sharp program that takes two numbers as input and 
        /// performs an operation(+,-,*,x,/) on them and displays the result of that operation.
        /// </summary>
        public static void Question01()
        {
            int a = 4, b = 5;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            int x = 1;
            Console.WriteLine(a / x);
        }
        /// <summary>
        /// 2. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 
        /// (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void Question02()
        {
            //// cách 1: nhập từng giá trị vào thuộc đoạn [-5,5] thìxuất giá trị x, không thuộc thì bắt nhập lại 
            //Console.WriteLine("Tinh ham  x = y\u00B2 + 2y + 1 \ny phai thuoc doan [-5,5]");
            //Console.Write("Nhap gia tri y = ");
            //double y = double.Parse(Console.ReadLine());
            //while (y < -5 || y > 5) 
            //{
            //    Console.WriteLine("y phai thuoc doan [-5,5]");
            //    Console.Write("Nhap gia tri y = ");
            //    y = double.Parse(Console.ReadLine());
            //}
            //double x = Math.Pow(y, 2) - 2 * y + 1;
            //Console.WriteLine($"Voi y={y} thi x= ({y})\u00B2 + 2{y} + 1 = {x}");

            // cách 2: xuất nguyên 1 chuỗi các giá trị x chạy y từ -5 tới 5 
            Console.WriteLine("Tinh ham  x = y\u00B2 + 2y + 1, voi y thuoc doan [-5,5]");
            for (double y = -5; y <= 5; y++)
            {
                double x = Math.Pow(y, 2) + 2 * y + 1;
                Console.WriteLine($"voi y = {y} thi x = ({y})\u00B2 + 2{y} + 1 = {x} ");
            }
        }
        /// <summary>
        /// 3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input 
        /// and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
        /// </summary>
        public static void Question03()
        {
            // Tính thời gian
            Console.WriteLine("Nhap thoi gian di duoc tinh theo gio, phut, giay");
            Console.Write("Nhap so gio h = ");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("Nhap so phut m = ");
            double minutes = double.Parse(Console.ReadLine());
            Console.Write("Nhap so giay s = ");
            double seconds = double.Parse(Console.ReadLine());
            double t = hours * 3600 + minutes * 60 + seconds;
            Console.WriteLine($"Tong so thoi gian di duoc tinh theo giay la: {t} ");

            // Đoạn đường
            Console.Write("doan duong di duoc tinh bang km hay m? Tra loi: ");
            string khoangcach = Console.ReadLine();
            if (khoangcach == "m")
            {
                Console.Write("Nhap doan duong di duoc s = ");
                double s = double.Parse(Console.ReadLine());
                double v1 = s / t;
                double v2 = (s / t) * 1000;
                Console.WriteLine($"Van toc di duoc \n Tinh m/s la v = {v1} \n Tinh theo km/s la v = {v2} ");
            }
            else
            {
                Console.Write("Nhap doan duong di duoc s = ");
                double s = double.Parse(Console.ReadLine());
                double v1 = s / t;
                double v2 = (s / t) / 1000;
                Console.WriteLine($"Van toc di duoc \nTinh km/s la v = {v1} \nTinh theo m/s la v = {v2} ");
            }
        }
        /// <summary>
        /// 4. Write a C# Sharp program that takes the radius of a sphere as input and 
        /// calculates and displays the surface and volume of the sphere.V = 4/3*π*r3
        /// </summary>
        public static void Question04()
        {
            Console.Write("Nhap gia tri ban kinh hinh cau r = ");
            double r = double.Parse(Console.ReadLine());
            double V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Voi r = {r} thi V = {V}");
        }
        /// <summary>
        /// 5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, 
        /// a digit, or any other symbol.
        /// </summary>
        public static void Question05()
        {
            char c = char.Parse(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine(" ky tu duoc nhap vao la nguyen am");
            }
            else if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
            {
                Console.WriteLine("ky tu vua nhap la so");
            }
            else
            {
                Console.WriteLine("ky tu khac");
            }
                
        }
    }
}
