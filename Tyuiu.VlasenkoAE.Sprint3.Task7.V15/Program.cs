using Tyuiu.VlasenkoAE.Sprint3.Task7.V15.Lib;

Console.Title = "Спринт #3 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
Console.WriteLine("* F(x) = sin(x) + (2x)/3 - cos(x) * 4x (произвести табулирование)         *");
Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1.                           *");
Console.WriteLine("* Произвести проверку деления на ноль.                                    *");
Console.WriteLine("* При делении на ноль вернуть значение 0. Значения занести в массив.      *");
Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

DataService ds = new DataService();
int len = ds.GetMassFunction(startValue, stopValue).Length;

double[] valueArray;
valueArray = new double[len];
valueArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+----------+----------+");
Console.WriteLine("|     X    |   f(x)   |");
Console.WriteLine("+----------+----------+");

int currentX = startValue;
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("|{0,5:d}     | {1,8:f2} |", currentX, valueArray[i]);
    currentX++;
}
Console.WriteLine("+----------+----------+");
Console.ReadKey();