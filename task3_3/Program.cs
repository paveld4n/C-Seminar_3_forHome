// Получить число N и выдать квадраты от 1 до N
Console.WriteLine("Введите число ");
bool isNumX = int.TryParse(Console.ReadLine(), out int x);

if(!isNumX)
{
    Console.WriteLine("Ошибка! Ввели не то. переВВедите.");
    return;
}

TableOfQuarter(x);

void TableOfQuarter(int num)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = (i + 1) * (i + 1);
        Console.WriteLine($"Квадрат {i +1} равен {array[i]}");
    }
}