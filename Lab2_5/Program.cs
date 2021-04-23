using System;

namespace Lab2_5A
{
    class Program
    {
        static void Main()
        {
            int size = SetSizeArray();
            int[,] A = new int[size, size];
            SetValueArray(A); // генерація значень елементів масива
            PrintArray(A); // вивід вмісту масива на екран
            Console.WriteLine("\nCереднє арифметичне елементів бічної діагоналі матриці = {0:N2}", ArithmeticMean(A));
            _ = Console.ReadKey(true); //пауза
        }

        public static int SetSizeArray() // задає розмір масива
        {
            string str;
            int sizeArray; // для збереження розміру масива
            do
            {
                do
                {
                    Console.Write("\nВведіть розмір масиву: ");
                    str = Console.ReadLine();
                } while (int.TryParse(str, out sizeArray) == false);

                if (sizeArray < 1)
                {
                    Console.WriteLine("\nРозмір не може бути менше одиниці!\n");
                }
            } while (sizeArray < 1);
            return sizeArray;
        }

        public static void SetValueArray(int[,] arr) // встановлення значень елементів масива
        {
            int num;
            do
            {
                do
                {
                    Console.WriteLine("Значення елементів масиву задавати:");
                    Console.WriteLine("1) З клавіатури");
                    Console.WriteLine("2) за допомогою генератора псевдовипадкових чисел з відрізка[-100; 100]");
                } while (int.TryParse(Console.ReadLine(), out num) == false);
                if (num == 1)
                {
                    string str;
                    Console.WriteLine(); // відступ в один рядок
                    for (int i = 0; i < arr.GetLength(0); i++) // цикл по рядках
                    {
                        for (int j = 0; j < arr.GetLength(1); j++) // цикл по стовпцях
                        {
                            do
                            {
                                Console.Write("arr[{0}][{1}] = ", i, j);
                                str = Console.ReadLine();
                            } while (!int.TryParse(str, out arr[i, j]));
                        }
                    }
                }
                else if (num == 2)
                {
                    Random random = new Random();
                    for (int i = 0; i < arr.GetLength(0); i++) // цикл по рядках
                    {
                        for (int j = 0; j < arr.GetLength(1); j++) // цикл по стовпцях
                        {
                            arr[i, j] = random.Next(-100, 100);
                        }
                    }
                }

            } while (num != 1 && num != 2);
        }

        public static void PrintArray(int[,] arr) // вивід вмісту масива на екран
        {
            Console.WriteLine("\nВведений масив:");
            for (int i = 0; i < arr.GetLength(0); i++) // цикл по рядках
            {
                for (int j = 0; j < arr.GetLength(1); j++) // цикл по стовпцях
                {
                    Console.Write("A[{0}][{1}] = {2}\t", i, j, arr[i, j]);
                }
                Console.WriteLine(); // відступ в один рядок
            }
        }

        public static double ArithmeticMean(int[,] arr)
        {
            double summ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j == arr.GetLength(1) - 1)
                    {
                        summ += arr[i, j];
                    }
                }
            }
            return summ / arr.GetLength(1);
        }
    }
}
