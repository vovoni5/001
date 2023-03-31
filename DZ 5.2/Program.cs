Console.Write($"Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.WriteLine ($"Вторая цифра -> {result}");


int SecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = number - firstDigit * 100 - thirdDigit;
    return result / 10;
} 
