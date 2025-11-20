using Tyuiu.MolokanovNK.Sprint5.Task0.V18.Lib;

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
Console.WriteLine("* Дано выражение             . Вычислить значение при x = 3,              *");
Console.WriteLine("* результат сохранить в файл и вывести на консоль.                        *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 3;
Console.WriteLine($"x = {x}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string result = ds.SaveToFileTextData(x);

Console.WriteLine("Файл:" + result);
Console.WriteLine("Создан!");


Console.ReadKey();