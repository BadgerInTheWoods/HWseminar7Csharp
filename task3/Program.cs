// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MultiplyMatrix(int[,] m1, int[,] m2)
{
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m1.GetLength(1); j++)
        {
            m1[i, j] = m1[i, j] * m2[i, j];
        }
    }
    return m1;
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
    Console.WriteLine();
}

int[,] matrix1 = CreateMatrixRndInt(4,4,0,9);
int[,] matrix2 = CreateMatrixRndInt(4,4,0,9);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
PrintMatrix(MultiplyMatrix(matrix1,matrix2));