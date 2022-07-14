int num = new Random().Next(100,1000);

 int res = RemoveSecond(num);

 Console.WriteLine($"{num} -> {res}");

int RemoveSecond(int num)
{
 int first = num / 100;
 int third = num % 10;
 return first*10+third;
}