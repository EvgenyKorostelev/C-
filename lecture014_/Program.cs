//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Func(int numTemp)
{
    int result = 0;
    int count = 1;
    while(count < numTemp)
    {
        result = count * count;
        count++;
        Console.Write(result + ", ");
    }
    result = count * count;
    Console.Write(result + ".");
}

Console.Write($"Таблица квадратов чисел от 1 до {num}: ");
Func(num);