// Заполнение двумерного массива
void FillArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 10);  // [1, 10)
        }
    }
}

// Вывод двумерного массива на экран
void PrintArray(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = new int [5, 6];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);