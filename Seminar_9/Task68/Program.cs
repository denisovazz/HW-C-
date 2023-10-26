int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int Akkerman = Akk(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");

int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0 && m > 0) return Akk(m - 1, 1);
  else return Akk(m - 1, Akk(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}