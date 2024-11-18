using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_9
{
    internal class Program
    {
        // Задание 1
        public static void PER()
        {
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("x3 = ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            int y3 = int.Parse(Console.ReadLine());

            double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine($"Периметр треугольника: {side1 + side2 + side3}");
        }

        public static void S()
        {
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("x3 = ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            int y3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь треугольника: {0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))}");
        }
        
        // Задание 2
        static void n2()
        {
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            int tens = number / 10;
            int ones = number % 10;

            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {ones}");

            int sum = tens + ones;
            Console.WriteLine($"Сумма цифр: {sum}");

            int pr = tens * ones;
            Console.WriteLine($"Произведение цифр: {pr}");

            int m = ones * 10 + tens;
            Console.WriteLine($"Новое число: {m}");
        }

        static void Main(string[] args)
        {
            // Задание 1
            PER();
            S();

            // Задание 2
            n2();

            Console.Read();
        }
    }
}
