// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double[]CreateArrarRandIntDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double SearchMaxArrayIndex(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];

    }
    return max;
}   

double SearchMinArrayIndex(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];

    }
    return min;
}   


double[] array = CreateArrarRandIntDouble(5, 0, 10);
PrintArrayDouble(array);

double maxIndex = SearchMaxArrayIndex(array);
double minIndex = SearchMinArrayIndex(array);
double differenceMaxMinIndex = maxIndex - minIndex;

Console.WriteLine($" => {maxIndex:F1} - {minIndex:F1} = {differenceMaxMinIndex:F1}");





