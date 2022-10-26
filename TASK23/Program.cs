// Задача 23
// Напишите программу, которая 
// 1. принимает на вход число (N) и
// 2. выдаёт таблицу кубов чисел от 1 до N.

void Table(int n)
{
    if (n > 0)
    {
        int index = 3;
        while (index <= n)
        {
            Console.WriteLine($"{index,4} {index*index*index,4}");
            index++;
        }
    }
    else Console.WriteLine("Некорректное число");
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

Table(n);
