// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();

int[,] array2d1 = CreateMatrixRndInt(2, 2, -10, 10);
int[,] array2d2 = CreateMatrixRndInt(2, 2, -10, 10);
PrintMatrix(array2d1);
Console.WriteLine("------------");
PrintMatrix(array2d2);
Console.WriteLine("------------");
PrintMatrix(CompositionMatrix(array2d1,array2d2));


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{ // 0 1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] CompositionMatrix(int[,] martix1, int[,] martix2)
{
    int[,] array = new int[martix1.GetLength(0), martix2.GetLength(1)];
    
    for (int i = 0; i < martix1.GetLength(0); i++)
    {
        for (int j = 0; j < martix1.GetLength(1); j++)
        {
            
            for (int k = 0; k < martix1.GetLength(0);k++)
            {
                array[i,j] += martix1[i, k] * martix2[k, j];
            }
        }
    }
    return array;
}