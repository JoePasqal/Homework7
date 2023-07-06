// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

const int Rows = 3;
const int Columns = 4;

int[,] GetRandomMatrix(int row, int columns)
{
    int[,] matrix = new int[row, columns];   //выделение памяти
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);

double[] AvgArifmeticheskoe = new double[Columns];
for(int j =0; j < Columns; j++)
{
    int sum = 0;
    for(int i = 0; i < Rows; i++)
    {
        sum += myMatrix[i, j];
    }
    AvgArifmeticheskoe[j] = (double) sum / Rows;
}

Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
Console.WriteLine(string.Join(",", AvgArifmeticheskoe));
