Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0;
while (numberB < numberA)
{
    numberB++;
    if (numberB % 2 == 0)
    {
        Console.Write(numberB + " ");

    }
    
}
