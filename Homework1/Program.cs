void PrintNaturalNumber(int m, int n)
{
    if (m == n) Console.Write($"{n} ");
    else
    {
        Console.Write($"{m} ");
        PrintNaturalNumber(m + 1, n);
        
    }
    
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
PrintNaturalNumber(m, n);