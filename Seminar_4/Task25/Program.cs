int ReadNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int Sq(int a, int b)
{
    int sq = a;

    for(int i = 1; i < b; i++)
    { 
        sq = sq * a;
    }
    return sq;
}

int numberA = ReadNumber("Введите число:");
int numberB = ReadNumber("Введите число:");

int result = Sq(numberA,numberB);
System.Console.WriteLine(result);

