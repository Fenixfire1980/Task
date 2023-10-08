// Напишите программу, которая будет создавать копию заданного масива с помощью поэлементного копирования.




int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void mas(int m)
{
for (int i = 0; i < m; i++)
{
Console.WriteLine($»Введите {i+1} элемент массива «);
Array[i] = Convert.ToInt32(Console.ReadLine());
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