Console.WriteLine("введите число соответствующее дню недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
    Console.WriteLine("Выходной!");
else if (num > 0 && num < 6)
    Console.WriteLine("не выходной");
else
    Console.WriteLine("нет такого дня недели");

