




int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetRemainder(int num1, int num2)
{
   return num1 % num2;
}



int firstNum = GetUserInput("Введите первое число");
int secondNum = GetUserInput("Введите второе число");

int rem = GetRemainder(firstNum, secondNum);

if (rem == 0)
{
    Console.WriteLine($"Число {firstNum} кратно {secondNum}");
}
else
{
     Console.WriteLine($"Число {firstNum} не кратно {secondNum} ,остаток {rem}");
}
