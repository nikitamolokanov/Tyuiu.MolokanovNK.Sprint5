using System.IO;
using Tyuiu.MolokanovNK.Sprint5.Task7.V17.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Молоканов Н. К. | ПКТб-23-2";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ПКТб-23-2                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V17.txt. в котором есть набор *");
Console.WriteLine("* символьных данных. Удалить все удвоенные буквы \"нн\" из файла. Полученный*");
Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V17.txt.                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Находится в файле: ");
Console.WriteLine(ds.LoadDataAndSave(path));
Console.ReadKey();