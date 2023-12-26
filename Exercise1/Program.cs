using System;

/*
* Задание 1.
* 1.

Дан двумерный массив.

732

496

185

Отсортировать данные в нем по возрастанию.

123

456

789

Вывести результат на печать.

class Program

{

static void Main(string[] args)

{

int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

}

}

*/

namespace ConsoleApp15
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            // Преобразуем двумерный массив в одномерный
            int[] flattenedArray = new int[a.GetLength(0) * a.GetLength(1)];
            int index = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    flattenedArray[index++] = a[i, j];
                }
            }

            // Сортируем одномерный массив
            Array.Sort(flattenedArray);

            // Выводим отсортированный результат
            index = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = flattenedArray[index++];
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}