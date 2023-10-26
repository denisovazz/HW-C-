int N = InputNumbers("Введите N: ");

PrintNature(N);

void PrintNature(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.Write(n+" ");
    PrintNature(n-1);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}