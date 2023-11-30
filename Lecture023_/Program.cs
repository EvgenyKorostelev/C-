//Задайте двумерный массив из целых чисел. Напишите программу, 
//которая заменит все элементы в  
//строке и столбеце на 0, на пересечении которых 
//расположен наименьший элемент массива.

int [,] MyArray(int[,] array){
    int min = array[0,0];
    int rowIndex = 0;
    int colIndex = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if (min>array[i,j]){
                rowIndex = i;
                colIndex = j;
                min = array[i,j];
            }
        }
    }
    for(int i = 0; i<array.GetLength(0); i++){
        array[i,colIndex] = 0;
    }
    for(int j = 0; j<array.GetLength(1); j++){
        array[rowIndex,j] = 0;
    }
    return array;

}
