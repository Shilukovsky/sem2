int num = new Random().Next(10,100);
int MaxDigit (int number)
{  
    int first = number / 10;
    int second = number % 10;
    if (first == second) return 0;
    if (first > second) return first;
    return second;
}
int maxDigit = MaxDigit(num);
if(maxDigit == 0) Console.WriteLine($"{num} -> цифры одинаковые");
else Console.WriteLine($"{num} -> {maxDigit}");