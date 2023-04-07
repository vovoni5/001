Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number}: {sumNumbers}");

int SumNumbers(int num)
{
    int a = 10;
    int b = 1;
    int sum = 0;
    while (num != 0)
    {
        num = num % a / b;
        sum = sum + num;
        a = a * 10;
        if (b < 10)
        {
            b = b * 10;
            continue;
        }
    }

    return sum;
}