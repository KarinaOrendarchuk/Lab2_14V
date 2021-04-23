using System;
using static System.Math;

namespace Lab2_3B
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = new int[SetSizeArray()]; // ініціалізація масива розміром який задав користувач

            SetValueArray(arr); // встановлення значень елементів масива
            PrintArray(arr); // друк масива в консоль

            Console.WriteLine("1) Добуток елементів масиву з парними номерами: {0}", DobElem(arr));
            Console.WriteLine("2) Cума елементів масиву, розташованих до максимального за модулем елемента: {0}", SummToMaxModule(arr));
            _ = Console.ReadKey(true);
        }

        public static int SetSizeArray() // запит корректного розміру масива
        {
            string str;
            int sizeArray; // для збереження розміру масива
            do
            {
                do
                {
                    Console.Write("Введіть розмір масиву: ");
                    str = Console.ReadLine();
                } while (!int.TryParse(str, out sizeArray)); // запитує розмір масива доки не буде введено число

                if (sizeArray < 1)
                {
                    Console.WriteLine("\nРозмір масива не може бути менше одиниці!\n");
                }
            } while (sizeArray < 1); // надоїдає доки число менше одиниці
            Console.WriteLine();

            return sizeArray; // повертає розмір масива
        }

        public static void SetValueArray(int[] arr) // встановлення значень елементів масива
        {
            Random aRand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = aRand.Next(-100, 100); // генерація чисел в діапазоні [-100, 100]
            }
        }

        public static void PrintArray(int[] arr) // друк масива в консоль
        {
            Console.WriteLine("\nВведений масив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]); 
            }
            Console.WriteLine();
        }

        public static long DobElem(int[] arr)
        {
            if (arr.Length < 2)
            {
                return 0;
            }
            long dob = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((1 + i) % 2 == 0)
                {
                    dob *= arr[i];
                }
            }
            return dob;
        }

        public static long SummToMaxModule(int[] arr)
        {
            long summ = 0;
            int max_i = 0;
            for (int i = 0, max = arr[0]; i < arr.Length; i++)
            {
                if (Abs(arr[i]) > Abs(max))
                {
                    max = arr[i];
                    max_i = i;
                }
            }

            for (int i = 0; i < max_i; i++)
            {
                summ += arr[i];
            }
            return summ;
        }
    }
}
