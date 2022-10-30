Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Максимальное число: " + numberA);
    Console.WriteLine("Минимальное число: " + numberB);
}
else
{
    Console.WriteLine("Максимальное число: " + numberB);
    Console.WriteLine("Минимальное число: " + numberA);
}