// Получить число N и выдать квадраты от 1 до N
Console.WriteLine("Введите число ");
bool isNumX = int.TryParse(Console.ReadLine(), out int n);

if(!isNumX)
{
    Console.WriteLine("Ошибка! Ввели не то. переВВедите.");
    return;
}

int [] GetTableSquares(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array [i] = (i + 1 ) * (i + 1);
    }
    return array;
}

int [] res = GetTableSquares(n);

PrintArray(res);
void PrintArray(int [] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Квадрат {i +1} равен {array[i]}");
    }
}