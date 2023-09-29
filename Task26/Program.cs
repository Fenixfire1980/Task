

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int LengthOffNumber(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int number = GetUserInput("Enter a number");
int length = LengthOffNumber(number);

Console.WriteLine($"{number} -> {length}");