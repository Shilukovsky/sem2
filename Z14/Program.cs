Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int res1 = num % 7;
int res2 = num % 23;
if (res1 == 0 && res2 == 0)
    Console.WriteLine($"{num}-> да");
else
    Console.WriteLine($"{num} -> нет");