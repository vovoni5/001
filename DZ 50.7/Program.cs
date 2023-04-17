// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
UserNumber(i,j, array2d);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
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
void UserNumber(int rows, int columnsnt, int[,] matrix)
{
    if (rows > matrix.GetLength(0) || columnsnt > matrix.GetLength(1))
             {
                Console.WriteLine($"Такого элемента в массиве нет");
             }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == rows && j == columnsnt)
            {
                Console.WriteLine($"Число на заданной вами позиции -> {matrix[i,j]}");
            }
        }
    }
}



