//Создать массив [-10, 10] размером 10
//Заменить положительные числа на отрицательные, а отрицательные на положительные


int [] CreateArrey(int min, int max, int size)
{
    int [] arrey = new int [size];
    for(int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(min, max+1);
    }
    return arrey;
}

void PrintArrey(int [] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write(arrey[i] + " ");
    }
    Console.WriteLine();
}

int [] ConvertArrey(int [] arrey)
{
    int [] newArrey = new int [arrey.Length];
    for(int i = 0; i < arrey.Length; i++)
    {
        newArrey[i] = arrey[i] * -1;
    }
    return newArrey;
}

Console.WriteLine("Enter array size");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int mx = Convert.ToInt32(Console.ReadLine());

int [] arrey1 = CreateArrey(mn, mx, s);

PrintArrey(arrey1);
PrintArrey(ConvertArrey(arrey1));
