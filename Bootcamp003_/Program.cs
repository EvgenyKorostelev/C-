//Сортировка выбором O(n^2)
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 21); //[-20, 20]
    }
}

int[] SortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++) // счеттчикуи цикла лучше обзывать: i, j, k, m, n, l
    {
        int indexMin = i;
        for(int j = i; j < array.Length; j++)
        {
            if(array[j] < array[indexMin])
            {
                indexMin = j;
            }        
        }
        if(array[indexMin] == array[i])
        {
            continue; // переход к следующей итерации цикла
        }
        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
    }
    return array;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] arr = new int[n];
InputArray(arr);
Console.WriteLine($"Исходный массив: [{string.Join(", ", arr)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", SortVibor(arr))}]");
