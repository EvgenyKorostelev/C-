//Сортировка массива через min/max

int[] arr = {1, 2, 5, 7, 3, 9, 2, 5, 1};

void PrintArrey(int[] arrey)
{
    int count = arrey.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arrey[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] arrey)
{
    for(int i = 0; i < arrey.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < arrey.Length; j++)
        {
            if(arrey[j] < arrey[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = arrey[i];
        arrey[i] = arrey[minPosition];
        arrey[minPosition] = temp;
    }
}

PrintArrey(arr);
SelectionSort(arr);
PrintArrey(arr);
