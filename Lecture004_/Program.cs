int num = 456;
int a = num / 10;
int b = a % 10;   // число, которое нужно возвести
int c = num % 10; // степень
int index = 1;
int result = b;
while (index < c)
{
    result = result * b;
    index++;
}
Console.WriteLine(result);