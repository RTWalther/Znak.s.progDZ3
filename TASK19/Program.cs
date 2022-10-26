// Задача 19
// Напишите программу, которая 
// 1.принимает на вход пятизначное число и 
// 2.проверяет, является ли оно палиндромом.
// 3.Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

    int firstDigit = num / 10000;
    int lastDigit =  num % 10 ;
    int SecondDigit = (num / 1000) %10; 
    int penultimateDigit = (num/10) % 10 ; 
    
if (firstDigit == lastDigit && SecondDigit == penultimateDigit ) 
{
Console.WriteLine("Да");
}
else 
{
Console.WriteLine("Нет"); 
}

