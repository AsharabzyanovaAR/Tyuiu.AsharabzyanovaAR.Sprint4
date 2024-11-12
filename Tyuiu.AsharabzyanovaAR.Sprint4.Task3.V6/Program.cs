using Tyuiu.AsharabzyanovaAR.Sprint4.Task3.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mas = new int[5, 5] {{8, 8, 3, 4, 5 },

                                     { 8, 6, 6, 4, 6 },

                                     { 3, 6, 5, 3, 4 },

                                     { 5, 6, 3, 7, 5 },

                                     { 7, 8, 5, 6, 6 } };

        int rows = mas.GetUpperBound(0) + 1;
        int columns = mas.Length / rows;
        DataService ds = new DataService();
        Console.Title = ("Спринт #3 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов.                    *");
        Console.WriteLine("* Найдите максимальный элемент во второй строке массива.                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{mas[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(mas);
        Console.WriteLine("Максимальное число-" + res);
        Console.ReadKey();
    }
}