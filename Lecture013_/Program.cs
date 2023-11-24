Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Func(int numTemp)
{
    int przv = 1;
    int count = 1;
    while(count <= numTemp)
    {
        przv = przv * count;
        count++;
    }
    Console.Write(przv);
}

Console.Write($"Произведение чисел от 1 до {num}: ");
Func(num);