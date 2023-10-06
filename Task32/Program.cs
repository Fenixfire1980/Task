// Замените положительные элементы масива на отрицательные и наоборот
// [-4,-8,8,2] -> [4,8,-8,-2]

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
void SignInversion(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        // number[i] *= -1;
        numbers[i] = -numbers[i];
    }
}
void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    // [^1] последний элемент масива
    Console.WriteLine($"{arr[^1]}");
}

int[] randArr = CreateArray(5,-10,11);
PrintOut(randArr);
SignInversion(randArr);
PrintOut(randArr);