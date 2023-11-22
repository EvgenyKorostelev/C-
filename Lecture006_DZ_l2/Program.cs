int num = 161;
if (num % 23 == 0 && num % 7 == 0)
{
    Console.WriteLine($"Число `{num}` кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число `{num}` НЕ кратно 7 и 23 одновременно");
}