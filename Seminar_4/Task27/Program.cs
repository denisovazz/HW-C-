int ReadNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int Sum(int a)
{
    int sum = 0;

    while(a>0)
    {
        sum += a%10;
        a = a/10;
    }
    return sum;
}

int number = ReadNumber("Введите число:");
int result = Sum(number);
System.Console.WriteLine(result);
