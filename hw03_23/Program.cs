// Задача 23. Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

var rnd = new Random();
int num = rnd.Next(1, 100);


System.Console.WriteLine();

for (int i = 1; i <= num; i++)
{
    System.Console.WriteLine($" куб числа {i,2}  = {i * i * i,8}");
}
