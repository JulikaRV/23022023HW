// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] newArray = GetArray(20, 100, 1000);
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(',', newArray)}]");
System.Console.WriteLine($"количество чётных чисел в массиве = {PosNumSum(newArray)}");


//function

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int PosNumSum(int[] arr)
{
    int sum = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
