Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Palindrome(num));

bool Palindrome(int number)
{
    int firstNum = number / 10000;
    int secondNum = number / 1000 % 10;
    int fourthNum = number % 100 / 10;
    int fifthNum = number % 10;
    return (firstNum == fifthNum && secondNum == fourthNum);
}