// Задайте массив из 12 чисел
// заполните случайными цыфрами из промежутка [-9:9]
// Найдите сумму отрицательных и положительных элементов массива
// Вывод результата






int[]CreateArrarRandint(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min,max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int [] GetSumPositiveNegativeLem(int[]arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }
    return new int[] {sumPositive, sumNegative};
}

int[] array = CreateArrarRandint(12, -9, 9);
PrintArray(array);
int[] sumPositiveNegativeLem = GetSumPositiveNegativeLem(array);
Console.WriteLine($"Сумма положительных элементов -> {sumPositiveNegativeLem[0]}");
Console.WriteLine($"Сумма отрицательных элементов -> {sumPositiveNegativeLem[1]}");