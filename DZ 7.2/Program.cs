Console.Write($"Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6)
{
    Console.Write($"НЕТ");
}
else
{
    Console.Write($"ДА");
}
