int[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] >= 0)
            {
                Console.Write(" " + matrix[i, j] + "\t ");
            }
            else
            {
                Console.Write(matrix[i, j] + "\t ");
            }
        }
        Console.WriteLine();
    }
}

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

/*
int[,] SortMatrix(int[,] matrix)
{
    int temp = 0;
    int numberOfColumns = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < numberOfColumns; j++)
        {
            for (int k = j + 1; k < numberOfColumns; k++)
            {
                if(matrix[i, j] > matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] newMatrix = CreateMatrixInt(5, 7, 1, 10);
PrintMatrixInt(newMatrix);
Console.WriteLine();
SortMatrix(newMatrix);
PrintMatrixInt(newMatrix);
*/

// **************************************************************************************

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
*/

/*
int FindMinSum(int[,] matrix)
{
    int numOfRow = 1;
    int sum = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempSum += matrix[i, j];
        }
        if(sum == 0)
        {
            sum = tempSum;
        }
        else if(tempSum < sum)
        {
            sum = tempSum;
            numOfRow = i + 1;
        }
    }
    return numOfRow;
}

int[,] newMatrix = CreateMatrixInt(7, 3, 1, 5);
PrintMatrixInt(newMatrix);
Console.WriteLine();
System.Console.WriteLine("Row #" + FindMinSum(newMatrix) + " contains the smallest sum of elements");
*/

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
 1 2  3  4
12 13 14 5
11 16 15 6
10 9  8  7
*/

int[,] FillMatrixSpiral(int rows, int columns)
{
   int[,] matrix = new int[rows, columns];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = columns;
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = columns * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return matrix;
}

PrintMatrixInt(FillMatrixSpiral(7, 3));