// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateFillArray()
{
    double[] arr = new double[6];
    Random random = new Random();
    for (double i = 0; i < 6; i++)
    {
        arr[i] = -5 + random.NextDouble() * 10;
        Console.Write("{0,6:F2}", arr[i]);
    }
    Console.WriteLine();
    return arr;
}
double[] arr = CreateFillArray();

double Max(double[] arr)
{
    double[] maxArr = arr;
    double max = 0;
    for (double i = 0; i > arr.Length; i++)
    {
        if (maxArr[i] > max) max = maxArr[i];

    }
    return max;
}
double maximum = Max(arr);
Console.WriteLine("Максимальный элемент массива: " + maximum);

double Min(double[] arr)
{
    double[] minArr = arr;
    double min = 0;
    for (double i = 0; i > arr.Length; i++)
    {
        if (minArr[i] > min) min = minArr[i];

    }
    return min;
}
double minimal = Min(arr);
Console.WriteLine("Минимальный элемент массива: " + minimal);

double MaxMin(double[] arr)
{
    double[] NewArray = arr;
    double num = 0;
    num = Max(arr) - Min(arr);
    {
        return num;
    }
}
double arrM = MaxMin(arr);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + arrM);

// Не удается преобразовать double в int?
