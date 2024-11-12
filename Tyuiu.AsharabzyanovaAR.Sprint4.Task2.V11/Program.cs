using Tyuiu.AsharabzyanovaAR.Sprint4.Task1.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = ("Спринт #3 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* подсчитать сумму четных элементов массива                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите количество элементов массива:");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] numsArry = new int[len];
        for(int i = 0; i <= len - 1; i++)
        {
            numsArry[i] = rnd.Next(3, 8);
        }
        Console.Write("Массив:");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArry[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(numsArry);
        Console.WriteLine("Сумма чётных элементов-"+res);
        Console.ReadKey();
    }
}