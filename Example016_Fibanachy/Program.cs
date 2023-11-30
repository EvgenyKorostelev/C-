// Вывод чисел фибаначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)

int Fibanachy(int n)
{
    if(n == 1 || n == 2) return 1;
    else 
    return Fibanachy(n - 1) + Fibanachy(n - 2);
}

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"f({i}) = {Fibanachy(i)}");
}