Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int res = RemoveSecond(num);
if (num / 100 > 0 && num / 100 < 10)
    Console.WriteLine($"{num} второе число {res}");
else
    Console.WriteLine("это не трехзначное число");
int RemoveSecond(int num)
{
    int ost1 = num % 100;
    int ost2 = num % 10;
    return ost1 / 10 - ost2 / 10;
}