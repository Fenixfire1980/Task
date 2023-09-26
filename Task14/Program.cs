

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool DivisionTo7and23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}


int number = GetUserInput("Enter a number: ");
bool result = DivisionTo7and23(number);


Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");