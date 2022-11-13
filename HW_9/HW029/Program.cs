﻿int numberM, numberN;
//Задача 68: Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

IntputNumbers(out numberM, out numberN);

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM}, {numberN}) = {AckermannFunction(numberM, numberN)}");

void IntputNumbers(out int numberM, out int numberN)
{
    Console.Write("Введите число M: ");
    numberM = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    numberN = int.Parse(Console.ReadLine());
}