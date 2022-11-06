// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateFillArray()
{
    int[] arr = new int[6];
    for (int i = 0; i < 6; i++)
    {
        arr[i] = new Random().Next(-100, 101);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}
int[] arr = CreateFillArray();


int SumN(int[] arr)

{
    int sum = 0;
    for (int i = 0; i < 6; i++)
    {

        if (i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}
SumN(arr);
Console.WriteLine("Сумма элементов нечетных позиций равна: " + SumN(arr));
