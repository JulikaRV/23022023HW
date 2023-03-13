// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("insert 1 number:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("insert 2 number:  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max number is " + a + " and min number is " + b);
}
else if (a < b)
{
    Console.WriteLine("max number is " + b + " and min number is " + a);
}
else Console.WriteLine(" numbers are equal");

