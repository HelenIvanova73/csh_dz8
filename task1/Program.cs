/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols)
{
    int minRange = -10;
    int maxRange = 10;
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return array;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


int[,] SortArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = i; j < array.GetLength(1); j++)
                { 
                    if (array[k, i] <array[k, j])
                    {
                        int temp = array[k, i];
                        array[k, i] = array[k, j];
                        array[k, j] = temp;
                    }
                }
        }       
    }
    return array;
}
// int[,] SortRowsArray(int[,] array2D)
// {
//     int array = new int[array2D.GetLength(1)];
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//        array[i] = array2D[i] 

// }


// void Swapxy(int[] array, int i)
// {
//     int x = array.GetLength - 1;
//     int temp = array[x];
//     array[x] = array[y];
//     array[y] = temp;
//  }

// void Swap2FirstLast(int[,] array, int i)
// {
//     int lastRows = array.GetLength(0) - 1;
//     (array[0, i], array[lastRows, i]) = (array[lastRows, i], array[0, i]);
// }



int rows = ReadInt("Введите количество строк > ");
int cols = ReadInt("Введите количество столбцов > ");
int[,] array = GenerateArray2D(rows, cols);
PrintArray2D(array);
PrintArray2D(SortArray(array));
