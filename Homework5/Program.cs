/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
int RaiseNumberToPower(int a, int b)
{
    int counter = 1;
    int result = a;
    if(b == 0)
    {
        return 1;
    }
    else
    {
        while (counter < b)
        {
            result *= a;
            counter++;
        }
    }
    return result;
}


Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the positive power: ");
int power = Convert.ToInt32(Console.ReadLine());

if(power < 0)
{
    Console.WriteLine("Incorrect power input!");
}
else
{
    int numToPow = RaiseNumberToPower(number, power);
    System.Console.WriteLine(number + ", " + power + " -> " + numToPow);
}
*/

//********************************************************************************************

/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int GetSumOfDigits(int num)
{
    int temp = num % 10;
    int sum = temp;
    while (num > 0)
    {
        num = num / 10;
        temp = num % 10;
        sum += temp;
    }
    return sum;
}


Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    int positiveNumber = -1 * number;
    Console.WriteLine(number + " -> " + GetSumOfDigits(positiveNumber));
}
else
{
    Console.WriteLine(number + " -> " + GetSumOfDigits(number));
}
*/

//********************************************************************************************

/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter array element #" + i);
        array[i] = Convert.ToInt32(Console.ReadLine());
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

Console.Write("Enter array size: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if(arraySize < 1)
{
    Console.WriteLine("Incorrect array size!");
}
else
{
    int[] array1 = CreateArray(arraySize);
    Console.WriteLine();
    ShowArray(array1);
}
*/
