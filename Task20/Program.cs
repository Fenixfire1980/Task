

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double Distance(int x1, int y1, int x2, int y2)
{
double result = Math.Sqrt(Math.Pow(x2 -x1, 2) + Math.Pow((y2 - y1), 2));
return result;
}

int x1 = GetUserInput("Координаты первой точки\nВедите координату X");
int y1 = GetUserInput("Координаты первой точки\nВедите координату Y");
Console.WriteLine("---------------------------------");
int x2 = GetUserInput("Координаты второй точки\nВедите координату X");
int y2 = GetUserInput("Координаты второй точки\nВедите координату Y");

double distance = Distance(x1, y1, x2, y2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));