
int number = new Random().Next(99, 1000);
Console.WriteLine($"Случайное число из отрезка [99, 1000] -> {number}");
int DeletSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
int result = (DeletSecondDigit(number));
Console.WriteLine(result);