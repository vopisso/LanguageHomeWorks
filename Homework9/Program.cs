/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N.
*/

/*
int GetSumFromTo(int m, int n)
{
    if(m < n)
    {
        m += GetSumFromTo(m + 1, n);
    }
    return m;
}

Console.Clear();
Console.WriteLine("The sum is: " + GetSumFromTo(1, 15));
Console.WriteLine();
*/

//***********************************************************************************************

/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

/*
int GetSumOfDigits(int number)
{
    int sum = number % 10;
    number = number / 10;
    
    if(number > 0)
    {
        sum += GetSumOfDigits(number);
    }
    return sum;
}

Console.Clear();
System.Console.Write("Enter number: ");
int newNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n" + newNumber + " -> " + GetSumOfDigits(newNumber));
Console.WriteLine();
*/