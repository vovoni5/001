Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableSquare(num);

void TableSquare(int number)
{
    int count = 1;
    while (count <= number)
    {
        int squad = count * count * count;
        Console.WriteLine($"{count, 30} -> {squad, 5}");
        count++;
    }

}