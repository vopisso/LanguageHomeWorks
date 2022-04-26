int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i == array.Length - 1)
        {
            Console.Write("] ");
        }
        else
        {
            Console.Write(", ");
        }
    }
}

void ShowArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i == array.Length - 1)
        {
            Console.Write("] ");
        }
        else
        {
            Console.Write("; ");
        }
    }
}

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int CountArrayEvenNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0 && array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

Console.Write("Input array size number: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input three-digit min arary number: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input three-digit max array number: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(arraySize <= 0 || minNumber < 100 || maxNumber > 999)
{
    Console.WriteLine("Incorrect input!");
}
else
{
    int[] newArray = CreateRandomArray(arraySize, minNumber, maxNumber);
    ShowArray(newArray);
    Console.Write("-> " + CountArrayEvenNumbers(newArray));
}
*/

//**************************************************************************************************

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int SumOfEvenPositionElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i <= array.Length -1; i++)
    {
        if(i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;     
}

Console.Write("Input array size number: ");
int arraySize1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min arary number: ");
int minNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max array number: ");
int maxNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(arraySize1 < 1)
{
    Console.WriteLine("Incorrect array size!");
}
else
{
int[] newArray1 = CreateRandomArray(arraySize1, minNumber1, maxNumber1);
ShowArray(newArray1);
Console.Write("-> " + SumOfEvenPositionElements(newArray1));
}
*/

//**************************************************************************************************

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/*
double GetDifMaxMinElements(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        else if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}

double[] newArray2 = {-1.5, 1.1, 2.7, -3.25, -3.111, 5, 15.25};
ShowArrayDouble(newArray2);
Console.Write(" -> " + GetDifMaxMinElements(newArray2));
*/