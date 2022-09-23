void SumFromMtoN(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.WriteLine($" \nСумма от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    Console.Write($"{sum} ");
    SumFromMtoN(m, n, sum);
}

int ReadInputData(string message)
{
    Console.WriteLine(message);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}
int m = ReadInputData("Введите число M");
int n = ReadInputData("Введите число N");
int temp = m;
if (n == m)
{
    Console.WriteLine("0");
    return;
}
if (m > n)
{
    m = n;
    n = temp;
}
SumFromMtoN(m, n);