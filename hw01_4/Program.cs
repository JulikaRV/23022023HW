// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("insert 1-st number :  ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("insert 2-nd number:  ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("insert 3-th number:  ");
int e = Convert.ToInt32(Console.ReadLine());
int max = c;

if (max < d)
{
    max = d;
}
if (max < e)
{
    max = e;
}

Console.WriteLine("Max number is :  " + max);
