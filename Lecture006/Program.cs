int num =456234;
if(num<100)
{
    Console.WriteLine("нет");
}
else
{
    while(num>999)
    {
        num = num / 10;
    }
    Console.WriteLine($"Result is {num%10}");
}
// как найти третью цифру слева