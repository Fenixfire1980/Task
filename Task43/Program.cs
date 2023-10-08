

int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintOut(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]:F1}, ");
    }

    Console.WriteLine($"{arr[^1]:F1}]");
}

double[] InterPoint(double B1, double B2, double K1, double K2)
{

    double[] arr = new double[2];
    arr[0] = (B2 - B1) / (K1 - K2);
    arr[1] = (K1 * arr[0] + B1);
    return arr;

}


int b1 = UserInput("Введите точку b1");
int b2 = UserInput("Введите точку b2");
int k1 = UserInput("Введите точку k1");
int k2 = UserInput("Введите точку k2");
double[] pointArray = InterPoint(b1, b2, k1, k2);
if (k1 == k2)
{
    Console.WriteLine("Прямые паралельны");
}
else
{
    Console.Write("Точка пересечения двух прямых [x, y] => ");
    PrintOut(pointArray);
}


