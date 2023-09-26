// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool WeekNumbers(int num)
{
    return num >= 1 && num <= 5;
}


int number = GetUserInput("Введите число недели");
if (number <8)
{
    bool Week = WeekNumbers(number);
Console.WriteLine(Week ? ($"{number} -> нет") : ($"{number} -> да"));
} 
else
{
    Console.WriteLine("Не правильный ввод");
}