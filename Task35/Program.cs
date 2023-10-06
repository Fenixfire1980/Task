// Задайте ономерный массив из 123 случайных чисел
// Найдите количество элементов мвссива лежащих в отрезке 10,99




int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
  
    Console.WriteLine($"{arr[^1]}");
}

int CountOfNumbersInRange(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
         if (arr[i]>=min && arr[i]<=max) count++;
    }
    return count;
}

int[] randArr = CreateArray(123,-100,100);
PrintOut(randArr);
int result = CountOfNumbersInRange(randArr, 10, 99);
Console.WriteLine($" -> {result}");