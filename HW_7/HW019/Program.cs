// Задача 47. 
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.

double[,] matrix = new double[3, 4];

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] matr)
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

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


