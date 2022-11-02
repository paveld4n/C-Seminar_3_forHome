Console.WriteLine("Введите трехзначное число");
int enter = Convert.ToInt32(Console.ReadLine()); 
int thriedDig = GetThirdNum(enter);
Console.WriteLine(thriedDig);

int GetThirdNum(int num)
{
    int result = num % 100 / 10;
    bool res = CheckLenNum(num);
    return result;
}

bool CheckLenNum(int number)
{
    return number < 1000 && number > 99;
}

