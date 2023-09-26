

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsSquareTwoNumbers(int number1, int number2)
{
    return number1 == number2 * number2 || number2 == number1 * number1;
}


int num1 = GetUserInput("Введите певрое число");
int num2 = GetUserInput("Введите второе число");

bool Square = IsSquareTwoNumbers(num1, num2);
Console.WriteLine(Square ? "да" : "нет");
