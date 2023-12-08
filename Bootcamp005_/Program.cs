// Напишите программу, которая на вход принимает 2 числа.
// Необходимо сложить 2 значения между собой, без прямого сложения(a + b)

// int sumNumbers(int a, int b){
//     if (b == 0)
//         return a;
//     return sumNumbers(a + 1, b - 1);
// }

/*
a = 5 b = 3
S(5, 3) -> S(6, 2) -> S(7, 1) -> S(8, 0) -> 8
*/


// Console.Clear(); // очистка консоли
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n} + {m} = {sumNumbers(n, m)}");   

//---------------------------------------------------------------------
// код на питоне и сайт для просмотра визуального работы рекурсии
// def fn(array, leftIndex, rightIndex):
//     i = leftIndex
//     j = rightIndex
//     pivot = array[leftIndex]
//     while i <= j:
//         while array[i] < pivot:
//             i += 1
//         while array[j] > pivot:
//             j -= 1
//         if i <= j:
//             temp = array[i]
//             array[i] = array[j]
//             array[j] = temp
//             i += 1
//             j -= 1
//     if leftIndex < j:
//         fn(array, leftIndex, j)
//     if i < rightIndex:
//         fn(array, i, rightIndex)
    
//     return array

// 18:48
// https://recursion.vercel.app/

// fn([3, -10, 0, 2, -1, 9, 4, 5, 3], 0, 8)
//------------------------------------------------------------------------

// Быстрая сортировка   O(n * log2(n))
/*
[3, -10, 0, 2, -1, 9, 4, 5, 3]
pivot = 3   опорный элемент
[-10, 0, 2, -1] + [3, 3] + [9, 4, 5] = [-10] + [-1] + [0] + [2] + [3, 3] + [4] + [5] + [9]

[-10, 0, 2, -1]
pivot = -10
[] + [-10] + [0, 2, -1]

[0, 2, -1]
pivot = 0
[-1] + [0] + [2]


[9, 4, 5]
pivot = 9
[4, 5] + [9] + []

[4, 5]
pivot = 4
[] + [4] + [5]
*/


int[] quickSort(int[] array, int leftIndex, int rightIndex){
    Console.WriteLine($"[{string.Join(", ", array)}]\nleft={leftIndex}\nright={rightIndex}\n");
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    while (i <= j){ // [3, -10, 0, 2, -1, 9, 4, 5, 3]
        while (array[i] < pivot){
            i++;
        }
        while (array[j] > pivot){
            j--;
        }
        if (i <= j){
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    if (leftIndex < j)
        quickSort(array, leftIndex, j); // 0, 4
    if (i < rightIndex)
        quickSort(array, i, rightIndex);
    
    return array;
}


Console.Clear();
int[] array = {3, -10, 0, 2, -1, 9, 4, 5, 3};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", quickSort(array, 0, array.Length - 1))}]");