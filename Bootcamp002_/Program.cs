Console.Write("Введите размер стороны матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mtrx = new int[n,n];

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        mtrx[i,j] = (i + 1) * (j + 1);
        mtrx[j,i] = (i + 1) * (j + 1);
    }
    Console.WriteLine();
}    

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(mtrx[i,j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
// O(n^2 / 2)