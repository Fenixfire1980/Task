int Fuctorial(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum * i;
        }



    }
    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int FuctNumbers = Fuctorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {FuctNumbers}");