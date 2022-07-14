Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int res = RemoveThird(num);
if (num / 100 > 0)
    Console.WriteLine($"{num} третья цифра с конца {res}");
else
    Console.WriteLine("третьей цифры нет");
int RemoveThird(int num)
{
    int ost1 = num % 1000;
    int ost2 = num % 100;
    return ost1 / 100 - ost2 / 100;
}
