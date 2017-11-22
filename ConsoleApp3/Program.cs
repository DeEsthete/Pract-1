using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        const int DividerTen = 10, DividerHundred = 100, DividerThousand = 1000;
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
        }

        private static void Task8()
        {
            bool x = false, y = false;
            if (!x && !y)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (x || (!x && y))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if ((!x && y) || y)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static void Task7()
        {
            int number = 456;
            int unit1, unit2, unit3;
            int finalNumber;
            unit1 = (number - (number % DividerHundred)) / DividerHundred;
            unit2 = (number - (unit1 * DividerHundred) - (number % DividerTen)) / DividerTen;
            unit3 = (number - (unit1 * DividerHundred) - (unit2 * DividerTen));
            int temp = unit2;
            unit2 = unit3;
            unit3 = temp;
            Console.Write(unit1);
            Console.Write(unit2);
            Console.WriteLine(unit3);
        }

        private static void Task6()
        {
            int number = 0;
            int unit1, unit2, unit3, unit4;
            int sum, prod;
            Console.WriteLine("Введите 4-ех значное число");
            number = int.Parse(Console.ReadLine());
            unit1 = (number - (number % DividerThousand)) / DividerThousand;
            unit2 = (number - (unit1 * DividerThousand) - (number - (number % DividerHundred))) / DividerHundred;
            unit3 = (number - ((unit1 * DividerThousand) + (unit2 * DividerHundred) + (number % DividerTen))) / DividerTen;
            unit4 = (number - ((unit1 * DividerThousand) + (unit2 * DividerHundred) + (unit3 * DividerTen)));
            sum = unit1 + unit2 + unit3 + unit4;
            prod = unit1 * unit2 * unit3 * unit4;
            Console.Write("Сумма - ");
            Console.WriteLine(sum);
            Console.Write("Произведение - ");
            Console.WriteLine(prod);
        }

        private static void Task5()
        {
            int number;
            int ten, units;
            int SumOfDigits, ProductOfFigures;
            Console.WriteLine("Введите двузначное число");
            number = int.Parse(Console.ReadLine());
            ten = number / DividerTen;
            units = number % DividerTen;
            Console.Write("Число десятков - ");
            Console.WriteLine(ten);
            Console.Write("Число единиц - ");
            Console.WriteLine(units);
            Console.Write("Сумма цифр - ");
            SumOfDigits = ten + units;
            Console.WriteLine(SumOfDigits);
            Console.Write("Произведение цифр - ");
            ProductOfFigures = ten * units;
            Console.WriteLine(ProductOfFigures);
        }

        private static void Task4()
        {
            int number = 234;
            const int DaysPerWeek = 7;
            int week;
            Console.Write("Количество недель в ");
            Console.Write(number);
            Console.Write(" дней - ");
            week = number / DaysPerWeek;
            Console.Write(week);
        }

        private static void Task3()
        {
            int centimeter;
            int meters;
            const int CentimetersInMeters = 100;
            Console.WriteLine("Введите число в сантиметрах");
            String centimeter1 = Console.ReadLine();
            centimeter = int.Parse(centimeter1);
            meters = centimeter / CentimetersInMeters;
            Console.Write("Полных метров - ");
            Console.WriteLine(meters);
        }

        private static void Task2()
        {
            double radius;
            double diameter;
            double length;
            double area;
            Console.WriteLine("Введите радиус окружности");
            String rad = Console.ReadLine();
            radius = int.Parse(rad);
            diameter = radius * 2;
            length = Math.PI * diameter;
            area = Math.PI * (radius * radius);
            Console.Write("Длина окружности - ");
            Console.WriteLine(length);
            Console.Write("Площадь окружности");
            Console.WriteLine(area);
        }

        private static void Task1()
        {
            int y;
            int x;
            Console.WriteLine("Введите значение 'x' для выраженя; y=7x^2-3x+4");
            String X = Console.ReadLine();
            x = int.Parse(X);
            y = 7 * (x * x) - 3 * x + 4;
            Console.WriteLine(y);
        }
    }
}
