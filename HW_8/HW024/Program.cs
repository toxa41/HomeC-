int[,] matrix, secondArray, resultArray;
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

InputData(out matrix, out secondArray, out resultArray);
FillArrayRandom(matrix);
PrintArray2D(matrix);
Console.WriteLine();
FillArrayRandom(secondArray);
PrintArray2D(secondArray);
Console.WriteLine();

if (matrix.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            resultArray[i, j] += matrix[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] matrix)
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

void InputData(out int[,] matrix, out int[,] secondArray, out int[,] resultArray)
{
    int rows = ReadInt("Введите количество строк: ");
    int cols = ReadInt("Введите количество столбцов: ");
    matrix = new int[rows, cols];
    secondArray = new int[rows, cols];
    resultArray = new int[rows, cols];
}