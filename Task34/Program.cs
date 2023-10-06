// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




int[] RandomArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}," : $"{array[i]}]";
    }
    Console.Write(output);
}

int SumMultipleNumbers(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) summ ++;
      
    }
return summ;    
}

int[] arr = RandomArray(4);
PrintArray(arr);
Console.Write($" -> Четных чисел {SumMultipleNumbers(arr)}");