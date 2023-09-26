
int number = new Random().Next(99, 1000);
Console.WriteLine($"Случайное число из отрезка [99, 1000] -> {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine(result);