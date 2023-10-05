// задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int CiklNumber(int num1, int num2)
{
    int sum = num1;
    for (int i = 1; i < num2; i++)
    {
     checked
     {
         sum = sum * num1; 
     }
       
      
      
    }
    return sum;
}

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int ciklNumbers = CiklNumber(number1, number2);
Console.WriteLine($"Число {number1} возведенное в натуральную степень числа {number2} -> {ciklNumbers}");