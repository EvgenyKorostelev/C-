int a = 10, b = 99;
Console.Write("Введите целое, двузначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= a && num <= b)
{
    int c = num / 10;
    int d = num % 10;

// Другой вариант:
// int maxDigit = c > d ? c : d;
// Console.WriteLine(maxDigit);

    if(c > d)
    {
        Console.WriteLine($"`{c}` наибольшая цифра числа `{num}`");
    }
    if(c < d)
    {
        Console.WriteLine($"`{d}` наибольшая цифра числа `{num}`");
    }
    if(c == d)
    {
        Console.WriteLine($"цифра`{c}` равна цифре `{d}` в числе `{num}`");
    }
}
