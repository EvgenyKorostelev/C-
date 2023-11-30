// Создание 2мерного массива
int [,] Create2dArray(int row, int col, int min, int max)
{
    int [,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

// Вывод 2мерного массива на экран
void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
} 

// Задача
void Show2dSquare(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                Console.Write(array[i, j]*array[i, j]+ " ");
            }
            else
            {
               Console.Write(array[i, j] + " "); 
            }
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Enter row number: ");
int row =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter cow number: ");
int cow =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min number: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max number: ");
int max =Convert.ToInt32(Console.ReadLine());

int [,] create2dArray = Create2dArray(row, cow, min, max);
Show2dArray(create2dArray);
Console.WriteLine();
Show2dSquare(create2dArray);