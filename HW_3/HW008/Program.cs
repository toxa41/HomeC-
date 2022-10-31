Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < number+1)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}
