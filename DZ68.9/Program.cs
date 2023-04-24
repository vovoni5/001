// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();


Console.WriteLine($"Введите целое положительное число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите целое положительное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ack = Ackermann(number1, number2);

void CheckNumber(int num1, int num2)
{
    if (num1 < 0 || num2 < 0) Console.WriteLine("Ошибка! Введено отрицательное число!");
    else Console.WriteLine($"{ack}");
}

int Ackermann(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else
    {
        if (num2 == 0) return Ackermann(num1 - 1, 1);
        else return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
    }
}
        
   

CheckNumber(number1, number2);