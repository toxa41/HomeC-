// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double pointX;
double pointY;

Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = array [1];
int b = array [3];
int c = array [0];
int d = array [2];

if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (d-c)/(a-b);
    pointY = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.0}");
    Console.WriteLine($"Y: {pointY:0.0}");
}