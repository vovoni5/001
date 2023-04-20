// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] DecreasingRowsMatrix(int[,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] array = new int[matrix.GetLength(1)];

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i,j];
        }
        int temp;
            for (int j = 0; j < array.Length; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[j] < array[k])
                    {
                        temp = array[j];
                        array[j] = array[k];
                        array[k] = temp;
                    }                   
                }            
            }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = array[j];
        }
    }
    return matrix;
}

Console.Clear();
int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("------------------------------------");
int[,] decreasingRowsMatrix = DecreasingRowsMatrix(array2d);
PrintMatrix(decreasingRowsMatrix);