//создать массив
//перемножить первый элемент с последним, второй элемен с предпоследним ...
//если элемент не имеет пары то записать его как последний в новом массиве
//записать результаты в другой массив и вывести его

int [] CreateArray(int min, int max, int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateNewArray(int[] array)
{
  int[] result = new int[array.Length / 2 + array.Length % 2];
  int length = array.Length / 2;
  for (int i = 0; i < length; i++)
  {
    result[i] = array[i] * array[array.Length - i - 1];
  }
  if (array.Length % 2 > 0)
  {
    result[length] = array[length];
  }
  return result;
}

Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(min, max, size);
PrintArray(arr);
int[] newArr = CreateNewArray(arr);
PrintArray(newArr);