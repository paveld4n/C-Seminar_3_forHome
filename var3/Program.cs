Console.WriteLine("Введите число в котором не менее трех знаков");
int enter = Convert.ToInt32(Console.ReadLine());
if(enter <100)
{
    Console.WriteLine("Ошибка! В этом числе меньше трех знаков!");
}
else
    {
    int third = GetThirdNum(enter);
    Console.WriteLine(third);
    }


int GetLengtNum(int num)
{
    int count = 0;
    while(num > 0)
    {
        num /= 10;
        count++;
    }
    return count;

}

int GetThirdNum(int input)
{
    int lenght = GetLengtNum(input);
    int[] array = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        array[i] = input % 10;
        input /=10;
    }
    int res = (array[lenght-3]);
    return res;
}

