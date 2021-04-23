using System;
using static System.Math;

namespace Lab2_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    x   |    y=f(x)    |");
            Console.WriteLine("|-----------------------|");
            double a = -6; // від
            double b = 3; // до
            double dx = 0.75; // крок 
            double x = a;
            double y; // функція яку треба обчислити
            while (x <= b) // на промыжку а б
            {
                y = Pow(x, 3); // функція яку треба обчислити
                Console.WriteLine("| {0,6:N2} {2} {1,12:N2} |", x, y, "|"); // Виведення результату в вигляді таблиці
                x += dx; // збільшеннч х на крок dx
            }
            Console.WriteLine("-------------------------");
            _ = Console.ReadKey(true); // пазуа
        }
    }
}

 