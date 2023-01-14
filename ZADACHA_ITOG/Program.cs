// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string[] CreateArray()
{
    string[] array;
    Console.WriteLine("Введите массив строк через пробел:");
    string N = Console.ReadLine();
    array = N.Split(' ');
    return array;
}
void NewArrayStrings()
{
    string[] Array1 = CreateArray();
    string str = string.Join(", ", Array1);
    Console.Write($"[{str}] ->");
    int count = 0;
    string[] Array2 = new string[Array1.Length];
    foreach (string i in Array1)
    {
        if (i.Length <= 3)
        {
            Array2[count] = i;
            count++;
        }
    }
    Array2 = Array2.Where(e => e != null).ToArray();
    str = string.Join(", ", Array2);
    Console.WriteLine($"[{str}]");
}
NewArrayStrings();