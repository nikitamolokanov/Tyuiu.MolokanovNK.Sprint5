using Tyuiu.MolokanovNK.Sprint5.Task3.V7.Lib;

int x = 2;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнил: Молоканов Н. К. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Работа с файлами                                                  *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
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


Console.WriteLine("Значение Х = " + x);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string result = ds.SaveToFileTextData(x);

Console.WriteLine("Файл:" + result);
Console.WriteLine("Создан!");


Console.ReadKey();
