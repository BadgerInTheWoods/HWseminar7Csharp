// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)
bool matrixContains(int[,,] matrix, int randNumber)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                if (matrix[k, i, j] == randNumber)
                    return true;
            }
        }
    }
    return false;
}

int[,,] CreateMatrixRndInt(int stripes, int rows, int columns, int min, int max)
{
    int[,,] matrix = new int[stripes, rows, columns];
    Random rnd = new Random();
    int randNumber = new int();
    for (int k = 0; k < stripes; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                randNumber = rnd.Next(min, max + 1);

                while (matrixContains(matrix, randNumber))
                {
                    randNumber = rnd.Next(min, max + 1);
                }
                matrix[k, i, j] = randNumber;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    int stripes = matrix.GetLength(0);
    int rows = matrix.GetLength(1);
    int columns = matrix.GetLength(2);
    for (int k = 0; k < stripes; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($" {matrix[k, i, j]}({k},{i},{j})");
            }
        }
    }
}

int[,,] matrix = CreateMatrixRndInt(2, 2, 2, 10, 99);
PrintMatrix(matrix);
