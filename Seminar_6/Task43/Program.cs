int Number(string massege)
{
    System.Console.WriteLine(massege);
    int result = int.Parse(Console.ReadLine());
    return result;
}






int[] FillArray(int size)
{

int [] array = new int[size];


    for (int i = 0; i < array.Length; i++)
    {
    array[i] = Number($"Введите {i+1}-й элемент");
    
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0)
    {
        count++;
    }
    }
    return count;
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+" ");
    }
}
int length = Number("Введите число элементов: ");
int [] array = FillArray(length);
PrintArray(array);
System.Console.WriteLine($"Количество чисел больше нуля - {CountPositiveNumbers(array)}");
