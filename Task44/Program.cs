// Не ипользуя рекурсию, вывидите первые N чисел Фибоначи
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8


int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] Fibonachi(int n)
{
    int[] arr = new int[n];
    // arr[0]=0;
    arr[1] = 1;
    for (int i = 2; i < n; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;

}

int num = UserInput("Введите число");
if (num < 2) Console.WriteLine("Не коректный ввод"); return;
int[] Array = Fibonachi(num);
PrintArray(Array);