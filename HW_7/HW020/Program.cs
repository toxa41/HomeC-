//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


System.Console.Write("Введите строку: ");
int positionA = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.Write("Введите столбец: ");
int positionB = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] matrix = new int[3, 4];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintOutput(int[,] matr)
{
    if (positionA < 0 | positionA > matrix.GetLength(0) - 1 | positionB < 0 | positionB > matrix.GetLength(0) - 1)
    {
        System.Console.WriteLine("Элемента не существует");
    }
    else
    {
        System.Console.WriteLine("Значение элементав массива = {0}", matrix[positionA, positionB]);
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
PrintOutput(matrix);
