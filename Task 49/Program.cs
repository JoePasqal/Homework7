// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

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
Console.WriteLine("Vvedi stroku");
int row = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Vvedi stolbets");
int column = Convert.ToInt32(Console.ReadLine()); 

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);

if (row >= 0 && row < myMatrix.GetLength(0) && column >= 0 && column < myMatrix.GetLength(1))
{
 int element = myMatrix[row, column];
 Console.WriteLine($"Значение элемента: {element}");
}
 else
  {
   Console.WriteLine("ты че там пишешь? не по-пацански это");
  }