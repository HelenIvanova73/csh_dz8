/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
2 4 | 3 4 2
3 2 | 3 3 1
Результирующая матрица будет:
18 20 8
15 18 7
 */

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray2D(int rows, int cols)
{
    int minRange = 0;
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

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] Multiplication(int[,] a, int[,] b)
    {
        if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
        int[,] r = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    r[i,j] += a[i,k] * b[k,j];
                }
            }
        }
        return r;
    }
    
int rowsA = ReadInt("Введите количество строк 1й матрицы -> ");
int colsA = ReadInt("Введите количество столбцов 1й матрицы -> ");
int[,] matrixA = GenerateArray2D(rowsA, colsA);
PrintArray2D(matrixA);

int rowsB = ReadInt("Введите количество строк 2й матрицы -> ");
int colsB = ReadInt("Введите количество столбцов 2й матрицы -> ");
int[,] matrixB = GenerateArray2D(rowsB, colsA);
PrintArray2D(matrixB);

System.Console.WriteLine("Mатрица - произведение:");
PrintArray2D(Multiplication(matrixA, matrixB));
