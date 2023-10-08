
int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void masive(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int DigitPositiv(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        sum = sum + 1;
        i = i + 1;
    }
    return sum;
}


int n = UserInput("Введите количество элементов массива: ");
int[] array = new int[n];
masive(array);
Console.Write($" Чисел больше нуля: {DigitPositiv(array)}");

