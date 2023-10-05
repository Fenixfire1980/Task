// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumNumber(int num)
{
    int sum = 0;
    
        while (num > 0)
        {
        sum = sum + num % 10;
        num = num / 10;
        }

    return sum;
}
    
int number = GetUserInput("Введите число");

int sumnamber = SumNumber(number);

Console.WriteLine($"Сума чисел, числа {number} равняется {sumnamber}");