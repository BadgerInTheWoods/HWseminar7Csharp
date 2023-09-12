// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] BubbleSort(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (var i = 1; i < matrix.GetLength(1); i++)
        {
            for (var j = 0; j < matrix.GetLength(1) - i; j++)
            {
                if (matrix[k, j] < matrix[k, j + 1])
                {
                    int temp = matrix[k, j];
                    matrix[k, j] = matrix[k, j + 1];
                    matrix[k, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");// 5 is a gap between numbers
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[,] mat = BubbleSort(matrix);
// sorting(matrix);
PrintMatrix(mat);