Console.WriteLine("Введите трехзначное натуральное число");
int enter = Convert.ToInt32(Console.ReadLine());
int third = GetThirdNum(enter);
Console.WriteLine(third);

int lenght = GetLengtNum(input);
    int[] array = new int[lenght];

    for (int i = lenght - 1; i >= 0; i--)
    {
        array[i] = input % 10;
        input /=10;
    }
    if(int array[0] == 0)
    {
        Console.WriteLine("Ошибка! число не натуральное!");
    }
    
    
    int res = (array[2]);
    return res;