// Задача 19. Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
int numOrigin = number;
int numReverse = 0;


if (numOrigin >= 10000 && numOrigin <= 99999)
{
    for (int i = 0; i < 5; i++)
    {
        numReverse = numReverse * 10 + numOrigin % 10;
        numOrigin = numOrigin / 10;
    }
    System.Console.WriteLine("Реверсное число = " + numReverse);
    if (numReverse == number)
    {
        System.Console.WriteLine($"{numReverse} является палиндромом ");
    }
    else System.Console.WriteLine($"{numReverse} не является палиндромом ");
}
else System.Console.WriteLine("Число не является пятизначным числом");




