double[,] CreateRandomMatrixDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    double b = 0; 

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            b = new Random().NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(b, 2);  
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
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

void GetAverageOfColumn(int[,] matrix)
{
    string result = "Arithmetic average of each column: ";
    double sum = 0;
    double average = 0;
    int numberOfRows = matrix.GetLength(0);
    int numberOfColumns = matrix.GetLength(1);

    for (int j = 0; j < numberOfColumns; j++)
    {
        for (int i = 0; i < numberOfRows; i++)
        {
            sum += matrix[i, j]; 
        }
        average = Math.Round(sum / numberOfRows, 1);
        sum = 0;
        
        if(j < numberOfColumns - 1)
        {
            result = result + Convert.ToString(average) + "; ";
        }
        else
        {
            result = result + Convert.ToString(average) + ".";
        }
    }

    Console.WriteLine(result);
}

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
Console.Write("Enter the number of matrix rows: ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of matrix columns: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(numberOfRows <= 0 || numberOfColumns <=0)
{
    Console.WriteLine("Incorrect input!");
}
else
{
    double[,] newMatrix = CreateRandomMatrixDouble(numberOfRows, numberOfColumns, -10, 10);
    PrintMatrixDouble(newMatrix);
}
Console.WriteLine();
*/

// ************************************************************************************************

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/*
int[,] newMatrix = CreateMatrixInt(7, 7, 1, 100);

Console.WriteLine();
Console.Write("Enter line number: ");
int lineNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column number: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PrintMatrixInt(newMatrix);
Console.WriteLine();

if(lineNumber < 0 || columnNumber < 0)
{
    Console.WriteLine("Incorrect input!");
}
else if(lineNumber > newMatrix.GetLength(0) - 1 || columnNumber > newMatrix.GetLength(1) - 1)
{
    Console.WriteLine("There is no element with index [" + lineNumber + ", " + columnNumber + "]");
}
else
{
    Console.WriteLine("Your element is " + newMatrix[lineNumber, columnNumber]);
}
/*

// ************************************************************************************************

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
int[,] newMatrix = CreateMatrixInt(3, 4, 1, 10);

Console.WriteLine();
PrintMatrixInt(newMatrix);
GetAverageOfColumn(newMatrix);
Console.WriteLine();
*/