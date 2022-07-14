int num = new Random().Next(100,1000);
int first = num / 100;
 int third = num % 10;
 int res = first*10 + third
 Console.WriteLine($"{num} -> {first}{third}");