// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int LeastSumRow(int[,] matrix)
{
    int least = 0;
    int sum = 0;
    int sumtemp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumtemp += matrix[i, j];
        }
        if (sum == 0)
        {
            sum = sumtemp;
        }
        if (sum >= sumtemp)
        {
            sum = sumtemp;
            least = i;
        }
        sumtemp = 0;
    }
    return least;
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
Random rnd = new Random();
int[,] matrix = CreateMatrixRndInt(rnd.Next(4,10), 4, 0, 9);
PrintMatrix(matrix);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {LeastSumRow(matrix) + 1} строка");