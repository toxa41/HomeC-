
Console.Write("Введите длинну массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
Console.Write("Получаем массив: ");
for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(count + 1);
    
    Console.Write($"{array[i]}; ");    
}

