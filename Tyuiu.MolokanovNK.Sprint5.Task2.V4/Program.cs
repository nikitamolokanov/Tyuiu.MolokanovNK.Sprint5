using Tyuiu.MolokanovNK.Sprint5.Task2.V4.Lib;


int[,] mtrx = new int[3, 3] {  {5, -5, -6},
                               {-5, 6, -7},
                               { 7, 3, 5}  };

int rows = mtrx.GetLength(0);
int cols = mtrx.GetLength(1);

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Молоканов Н. К. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Работа с файлами                                                  *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #4                                                             *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция, ( F(x) = {cos(x)}/{x-0.4} + sin(x) * 8x + 2 )             *");
Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.*");
Console.WriteLine("* Произвести проверку деления на ноль.                                    *");
Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask1.txt                *");
Console.WriteLine("* и вывести на консоль в таблицу. Значения округлить до двух знаков после запятой.*");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Массив: ");
for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string result = ds.SaveToFileTextData(mtrx);

Console.WriteLine("Файл:" + result);
Console.WriteLine("Создан!");


Console.ReadKey();