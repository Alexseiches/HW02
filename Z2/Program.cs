Console.WriteLine("Введите первое число");
int A = ReadNumberFromConsole();
Console.WriteLine("Введите второе число");
int B = ReadNumberFromConsole();
int step = A;

int ReadNumberFromConsole()
{
    string input = Console.ReadLine();
    return int.Parse(input);
}

for (int i = 1; i < B; i++)
{
step = step * A;
}
Console.WriteLine(step);