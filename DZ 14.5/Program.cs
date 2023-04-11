int[] array = ArrayThreeDigit(4);
PrintArray(array);
Console.WriteLine();
int evenNumbers = EvenNumbers(array);
Console.WriteLine($"Колличество четных чисел в массиве ровняется -> {evenNumbers}");


int[] ArrayThreeDigit(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int EvenNumbers(int[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            size = size + 1;
        }
    }
    return size;
}
