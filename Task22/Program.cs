

void SquareNumbers(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3} -> {count * count, 5}");
        count = count + 1;
    }
}

Console.WriteLine("Enter digit");
int number = Convert.ToInt32(Console.ReadLine());
SquareNumbers(number);