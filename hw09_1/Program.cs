// Задача 1: Задайте значение N. Напишите программу, 
// которая выведет все четные натуральные числа в промежутке
//  от m до N . Выполнить с помощью рекурсии.

Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
void numbers(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}, ");
    }
    numbers(m + 1, n);

}
numbers(m, n);