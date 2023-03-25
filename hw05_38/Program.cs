// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

double[] newArray = GetArray(10, -20, 20);
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(',', newArray)}]");
double result = MinMaxDiff(newArray);
System.Console.WriteLine($"разница между максимальным и минимальным элементами массива = {Math.Round(result, 2)}");



//function

double[] GetArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max) + rnd.NextDouble();
    }
    return arr;
}

double MinMaxDiff(double[] arr)
{
    double min = 0;
    double max = 0;
    double res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    res = max - min;

    return res;
}
