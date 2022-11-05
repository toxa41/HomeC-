// Задача 25: 
// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

double calculation (int num, int degr)
{
    double result = Math.Pow(num, degr);
    return result;
}


double output = calculation (number, degree);
Console.WriteLine ($"Число {number} в степени {degree} равно {output}");

