
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());


if (B <= 0)
{
    Console.WriteLine($"Число {B} не натуральное(((");
    return;
}


double math = MathA(A, B);
Console.WriteLine($"{A} в степени {B} = {math}");

double MathA (int a, int b)
{
    double degree = Math.Pow (a, b);
    return degree;
}