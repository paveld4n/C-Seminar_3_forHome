Console.WriteLine("Введите трехзначное число");
int input = Convert.ToInt32(Console.ReadLine());
bool result = CheckNum(input);
if (result == false)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    Console.WriteLine("Ураааа!! Победа");
}


bool CheckNum(int num)
{
    return num < 1000 && num > 99;
}
