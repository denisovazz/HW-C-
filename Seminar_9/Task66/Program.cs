int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");

System.Console.WriteLine(Summ(M,N));

int Summ(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    
    return n + Summ(m, n-1);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}