
int[] RandomArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = rand.Next(2);
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
    Console.WriteLine(output);
}

void PrintArray2(int[] array)
{

Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
 
}

int[] arr = RandomArray(5);
PrintArray2(arr);




int[] array = new int[8];
int[] array2 = new int[8]{1,2,3,4,5,6,7,8};
int[] array3 = new int[]{8,7,6,5,4,3,2,1};
int[] array4 = {8,7,6,5,4,3,2,1};

var array5 = new int[8];