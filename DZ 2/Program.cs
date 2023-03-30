Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

int size = a;

if(size < b)
{
    size = b;
}

if(size < c)
{
    size = c;
}

Console.Write($"Максимальное число = {size}");