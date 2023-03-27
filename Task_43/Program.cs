#pragma warning disable
//Console.Clear();
Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

Console.Write("\nВведите значение b1:\t");
double b1;
double.TryParse(Console.ReadLine()!, out b1);
Console.Write("\nВведите значение k1:\t");
double k1;
double.TryParse(Console.ReadLine()!, out k1);
Console.Write("\nВведите значение b2:\t");
double b2;
double.TryParse(Console.ReadLine()!, out b2);
Console.Write("\nВведите значение k1:\t");
double k2;
double.TryParse(Console.ReadLine()!, out k2);

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");