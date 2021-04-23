using System;

namespace Lab2_1
{
    class Program
    {
        static void Main()
        {
            int number;
            Console.WriteLine("У будинку є квартири з номерами: 1-45");
            do
            {
                Console.WriteLine("\nВведіть номер квартири:");
                do
                {
                    Console.Write("№ ");
                } while (int.TryParse(Console.ReadLine(), out number) == false);

                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Поверх №1");
                        break;

                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("Поверх №2");
                        break;

                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        Console.WriteLine("Поверх №3");
                        break;

                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                        Console.WriteLine("Поверх №4");
                        break;

                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                        Console.WriteLine("Поверх №5");
                        break;

                    case 26:
                    case 27:
                    case 28:
                    case 29:
                    case 30:
                        Console.WriteLine("Поверх №6");
                        break;

                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                        Console.WriteLine("Поверх №7");
                        break;

                    case 36:
                    case 37:
                    case 38:
                    case 39:
                    case 40:
                        Console.WriteLine("Поверх №8");
                        break;

                    case 41:
                    case 42:
                    case 43:
                    case 44:
                    case 45:
                        Console.WriteLine("Поверх №9");
                        break;

                    default:
                        Console.WriteLine("Такої квартири немає");
                        break;
                }
            } while (number != 0);
        }
    }
}
