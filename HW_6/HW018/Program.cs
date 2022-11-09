// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double pointX;
double pointY;

Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int lineA = array [1];
int lineB = array [3];
int lineC = array [0];
int lineD = array [2];

if (lineA == lineB)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (lineD-lineC)/(lineA-lineB);
    pointY = (double) lineA*(lineD-lineC)/(lineA-lineB) + lineC;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.0}");
    Console.WriteLine($"Y: {pointY:0.0}");
}