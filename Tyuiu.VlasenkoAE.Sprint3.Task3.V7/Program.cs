using Tyuiu.VlasenkoAE.Sprint3.Task3.V7.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach заменить буквы g на цифру 4                      *");
Console.WriteLine("* в строке: gft hggt ntg.                                                 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "gft hggt ntg";
char replaceable = 'g';
char replacement = '4';

Console.WriteLine("Исходная строка: " + value);
Console.WriteLine("Искомый символ: " + replaceable);
Console.WriteLine("Cимвол замены: " + replacement);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Итоговая строка = " + ds.ReplaceCharOnNum(value, replaceable, replacement));

Console.ReadKey();