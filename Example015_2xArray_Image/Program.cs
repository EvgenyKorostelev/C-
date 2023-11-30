// Закрас области внутри контура на маленькой картинке
void FillImage(int x, int y)
{
    if (pix[x, y] == 0)
    {
        pix[x, y] = 1;
        FillImage(x - 1, y);
        FillImage(x, y - 1);
        FillImage(x + 1, y);
        FillImage(x, y + 1);
    }
}

// Рекурсия факториала
int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else 
    return n * Factorial(n - 1);
}
