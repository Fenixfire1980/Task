// Напишите программу, которая будет создавать копию заданного масива с помощью поэлементного копирования.




int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new ();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
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
  
    Console.WriteLine($"{arr[^1]}]");
}

int[] DublicateArray(int[] array)
{
    int[] dublicateArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        dublicateArray[i] = array[i];
    }
    return dublicateArray;
}

Console.WriteLine("Create Array");
int userSize = UserInput("Enter the size off array");
int userMin = UserInput("Enter the mim digit for range");
int userMax = UserInput("Enter the max digit for range");
int[]userArray = CreateArray(userSize, userMin, userMax);
PrintOut(userArray);
int[] newArray = DublicateArray(userArray);
PrintOut(newArray);