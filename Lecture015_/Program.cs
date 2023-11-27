// создание и заполнение массива рандомными числами в интервале
int [] CreateArrey(int min, int max, int size)
{
    int [] arrey = new int [size];
    for(int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(min, max+1);
    }
    return arrey;
}

//вывод массива на экран(консоль)
void PrintArrey(int [] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.WriteLine(arrey[i] + " ");
    }
    Console.WriteLine();
}

// нахождение элемента массива
bool FindDigit(int arrey, int digit)
{
    bool flag = false;
    for(int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i] == digit)
        {
            return true;
        }
    }

    return flag;
}

// есть ли число в массиве
Console.WriteLine("Enter array size");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int mn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int mx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter search digit");
int digit = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(mn, mx, s);
ShowArray(array);
bool res = FindDigit(array, digit);
if(res == true){
    Console.WriteLine("ДА");
}
else{
    Console.WriteLine("Нет");
}