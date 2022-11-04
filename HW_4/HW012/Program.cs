// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int summ = 0;

int calculate(int num1)
{
    int temp = 0;
    int summ = 0;
    while (num1 > 0)
    {
        temp = num1 % 10;
        summ = summ + temp;
        num1 = num1 / 10;

    }
    return summ;
}
int allSumm = calculate(number);
Console.WriteLine($"Сумма цифр числа равна: {allSumm}");
