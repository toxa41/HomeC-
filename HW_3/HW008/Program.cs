Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count < number)
{
    count++;
    Console.WriteLine(Math.Pow(count, 3));
    
}
