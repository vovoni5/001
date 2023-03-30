Console.Write("Введите четное число:");

int number = Convert.ToInt32(Console.ReadLine());
 
if(number % 2 == 0)
{
    Console.Write("Число четное");
}

else
{
    Console.Write($"Число нечентное");
}
