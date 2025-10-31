using Tyuiu.VlasenkoAE.Sprint3.Task4.V20.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
Console.WriteLine("* функции y=x/(cos(x) - x)+2,5. При х = 0 пропустить значение.            *");
Console.WriteLine("* Полученные значения перемножать.                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));

Console.ReadKey();