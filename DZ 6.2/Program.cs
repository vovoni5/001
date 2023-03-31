Console.Write($"Введите трехзначное или более число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99)
{
    Console.Write("Нет третьего числа");
}
else
{
string numbers = Convert.ToString(number);
Console.Write(numbers[2]);
}