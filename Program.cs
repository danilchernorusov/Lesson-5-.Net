using System;
public class Program
{
    public static int[,] GetArrays()
    {
        int len1, len2;
        do
        {
            Console.Write("Скiльки масивiв ви хочете додати до масиву? ");
            len1 = Convert.ToInt32(Console.ReadLine());
        } while (len1 <= 0);

        do
        {
            Console.Write("Скiльки елементiв ви хочете додати до 1 масиву? ");
            len2 = Convert.ToInt32(Console.ReadLine());
        } while (len2 <= 0);

        int[,] numbers = new int[len1, len2];

        Console.WriteLine("Введiть числа по черзi.");

        for (int i = 0; i < len1; i++)
        {
            Console.WriteLine($"Масив номер {i}.");
            for (int x = 0; x < len2; x++)
            {
                Console.WriteLine($"Число номер {x}.");
                numbers[i, x] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return numbers;
    }

    public static int[,] Landslide(int[,] numbers)
    {
        int len1 = numbers.GetLength(0);
        int len2 = numbers.GetLength(1);
        int[,] numbers2 = new int[len1, len2];
        for (int i = 0; i < len1; i++)
        {
            for (int x = 0; x < len2; x++)
            {
                if (i == len1 - 1)
                {
                    numbers2[0, x] = numbers[i, x];
                }
                else
                {
                    numbers2[i + 1, x] = numbers[i, x];
                }
            }
        }
        return numbers2;
    }
    public static void Main()
    {
        int[,] numbers = GetArrays();
        int[,] numbers2 = Landslide(numbers);

        Console.WriteLine("Ви створили ось таку таблицю:");

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int x = 0; x < numbers.GetLength(1); x++)
            {
                Console.Write($"{numbers[i, x]} ");
            }
            Console.Write("\n");
        }

        Console.WriteLine("\n Ми зробили таку таблицю:");

        for (int i = 0; i < numbers2.GetLength(0); i++)
        {
            for (int x = 0; x < numbers2.GetLength(1); x++)
            {
                Console.Write($"{numbers2[i, x]} ");
            }
            Console.Write("\n");
        }
    }
}