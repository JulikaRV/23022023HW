// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным. 

Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1: Console.WriteLine("Понедельник - это рабочий день"); break;
    case 2: Console.WriteLine("Вторник - это рабочий день"); break;
    case 3: Console.WriteLine("Среда - это рабочий день"); break;
    case 4: Console.WriteLine("Четверг - это рабочий день"); break;
    case 5: Console.WriteLine("Пятница - это рабочий день"); break;
    case 6: Console.WriteLine("Суббота - это выходной день"); break;
    case 7: Console.WriteLine("Воскресенье - это выходной день"); break;
    default: Console.WriteLine("Нет такого дня недели"); break;
}
