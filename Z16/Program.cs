Console.WriteLine("введите через Enter два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2 || num2 == num1 * num1)
    Console.WriteLine($"{num1},{num2} -> да");
else
    Console.WriteLine($"{num1},{num2} -> нет");

