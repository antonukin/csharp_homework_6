// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите угловой коэффициент первой фунции");
double k1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите свободный член первой фунции");
double b1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент второй фунции");
double k2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите свободный член второй фунции");
double b2 = Double.Parse(Console.ReadLine());

if((k1 == k2) && (b1 != b2))
{
    Console.WriteLine($"Графики функций y = {k1}x + {b1} и y = {k2}x + {b2} не пересекаются");
}
if((b1 == b2) && (k1 == k2))
{
    Console.WriteLine($"Введены одинаковые линейные функции");
}
if((b1 == b2) && (k1 != k2))
{
    Console.WriteLine($"Координаты пересечения графиков функций y = {k1}x + {b1} и y = {k2}x + {b2}: (0, {b1})");
}
if((b1 != b2) && (k1 != k2))
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения графиков функций y = {k1}x + {b1} и y = {k2}x + {b2}: ({x}, {y})");
}