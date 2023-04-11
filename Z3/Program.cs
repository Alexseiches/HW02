Console.WriteLine("Введите длинну массива");
int n = ReadNumberFromConsole();
int[] array = new int[n];

Console.WriteLine("Введите минимальное значение элемента массива");
int min = ReadNumberFromConsole();
Console.WriteLine("Введите максимальное значение элемента массива");
int max = ReadNumberFromConsole();


int ReadNumberFromConsole()
{
    string input = Console.ReadLine();
    return int.Parse(input);
}


void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}
void FillArray(int[] array)
{
    int[] array = new int.Random().Next(min, max);
}
// Я не понимаю как это сделать)


