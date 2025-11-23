using System.IO;
using Tyuiu.MolokanovNK.Sprint5.Task5.V4.Lib;

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
Console.WriteLine("* Дан файл с набором значений. Найти произведение всех вещественных чисел *");
Console.WriteLine("* в файле. Полученный результат вывести на консоль. У вещественных        *");
Console.WriteLine("* значений округлить до трёх знаков после запятой.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine( ds.LoadFromDataFile(path));
Console.ReadKey();


