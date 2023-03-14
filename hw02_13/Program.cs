// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int getDigit(int k)
{
    while (k >= 1000) k = k / 10;
    int n = k % 10;
    return n;
}
var rnd = new Random();
int digit = rnd.Next(0, 100000);
System.Console.WriteLine($"Заданное число -> {digit}");

int newDigit = 0;

if (digit > 100)
{
    newDigit = getDigit(digit);
    Console.WriteLine($"Третья цифра заданного числа -> {newDigit}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}

