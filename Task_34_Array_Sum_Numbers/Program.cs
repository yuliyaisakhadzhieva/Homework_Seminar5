// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateFillArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}
int[] arr = CreateFillArray();
EvNumCount(arr);

void EvNumCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("Количество четных чисел в массиве равно: " + count);
}

