// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

ArrayRandom(numbers);
Console.Write("Массив: ");
OutputArray(numbers);
int min = numbers[0];
int max = 0;


for (int j = 0; j < numbers.Length; j++)

    if (numbers[j] > max) max = numbers[j];
    
for (int z = 0; z < numbers.Length; z++)

    if (numbers[z] < min) min = numbers[z];

Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");


void ArrayRandom(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 900);
    }
}

void OutputArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
