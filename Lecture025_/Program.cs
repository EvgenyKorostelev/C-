// сумма натуральных чисел от 1 до n
int Sum(int n)
{
    if(n == 1) return 1;
    else return n + Sum(n - 1);
}


Console.WriteLine("Введите число n: ");
int x = Convert.ToInt32(Console.ReadLine());
int result = Sum(x);
Console.WriteLine(result);
