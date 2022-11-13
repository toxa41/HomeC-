int numberM, numberN;

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


InputNumbers(out numberM, out numberN);

void GapNumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);

void InputNumbers(out int numberM, out int numberN)
{
    Console.Write("Введите начальное число M: ");
    numberM = int.Parse(Console.ReadLine());
    Console.Write("Введите конечное число N: ");
    numberN = int.Parse(Console.ReadLine());
}