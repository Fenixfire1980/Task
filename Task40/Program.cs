// Напишите программу которая принимает на вход три числа 
// и проверяет может ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника
// Каждая сторона треугольника меньше сумы двух других сторон.



int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

int a = UserInput("Введите сторону А треугольника");
int b = UserInput("Введите сторону B треугольника");
int c = UserInput("Введите сторону C треугольника");

bool result = IsExistTriangle(a, b, c);

Console.WriteLine(result ? "Треугольник существует." : "Треугольник не существует.");

