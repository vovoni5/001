Console.Write("Введите первое число 1:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число 2:");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write($"max = {a}");
}

if(a < b)
{
    Console.Write($"max = {b}");
}
if(a == b)
{
    Console.Write($"Числа равны))))");
}