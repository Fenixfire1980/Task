// Напишите программу которая определяет присутствует ли задданое число в масиве
// 4; масив [6, 7, 19, 345, 3] -> нет
// 4; масив [6, 4, 19, 345, 3] -> да

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

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

bool FindNumber(int[]arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }

    }
    return false;
}

int numFind = GetUserInput("Введите число для поиска");
int[] randArr = CreateArray(5,-10,11);
PrintOut(randArr);
bool findNumber = FindNumber(randArr,numFind);
Console.WriteLine(findNumber? "Искомое число найдено":"Искомое число не найдено");