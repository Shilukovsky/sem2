int num = new Random().Next(10,100);
int first = num/10;
int second = num % 10;
if(first == second) Console.WriteLine("цифры одинаковые");
else if (first > second) Console.WriteLine($"{num} -> {first}");
else Console.WriteLine($"{num} -> {second}");