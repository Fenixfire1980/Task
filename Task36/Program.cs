// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}
void PrintOut(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
  
    Console.Write($"{arr[^1]}]");
}

int SumMultipleIndex(int[] arr)
{
    int summ = 0;
        for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 == 1) 
        summ = summ + arr[i];
      
    }
return summ;    

}
int[] arr = CreateArray(4);
PrintOut(arr);
Console.Write($" -> Сумма элементов, стоящих на нечётных позициях {SumMultipleIndex(arr)}");