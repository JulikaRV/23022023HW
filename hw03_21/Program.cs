// Задача 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.WriteLine("Введите координаты точки А1");
System.Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки А2");
System.Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());



double sum = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

System.Console.WriteLine($"Расстояние между двух точек в 3D пространстве равно {Math.Round(sum, 2)}");





