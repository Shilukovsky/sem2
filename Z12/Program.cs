Console.WriteLine("введите через ENTER два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num2 % num1;
if(res == 0)
Console.WriteLine("кратно");
else
Console.WriteLine($"не кратно, остаток {res}");

