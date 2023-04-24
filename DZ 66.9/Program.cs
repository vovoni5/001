// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();


Console.WriteLine($"Введите целое положительное число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите целое положительное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = SumNuturalNumbers(number1,number2);

void CheckNumber(int num1, int num2)
{
    if (num1 < 1 || num2 < 1) Console.WriteLine("Ошибка! Введено отрицательное число!");
    else Console.WriteLine($"{sum}");
}

int SumNuturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num1 < num2)
    {
        return num1 + SumNuturalNumbers(num1 +1, num2);
    } 
    else return num2 + SumNuturalNumbers(num1, num2 + 1);

}

CheckNumber(number1, number2);