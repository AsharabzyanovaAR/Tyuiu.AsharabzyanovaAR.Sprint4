using Tyuiu.AsharabzyanovaAR.Sprint4.Task1.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = ("Спринт #3 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* подсчитать произведение нечетных элементов массива                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.Write("Введите количество элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());
        int[] numsArry = new int[len];
        for (int i = 0; i <= len-1; i++)
        {
            Console.Write("Введите значение " + i + " элемента массива:");
            numsArry[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        Console.WriteLine();
        Console.WriteLine("Массив:");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArry[i] + "\t");

        }
        Console.WriteLine();
        Console.WriteLine();



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(numsArry);
        Console.WriteLine(res);
        Console.ReadKey();

    }
}