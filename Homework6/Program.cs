/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    int counter = 1;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter number #" + counter);
        array[i] = Convert.ToInt32(Console.ReadLine());
        counter++;
    }
    return array;
}

int ShowPositiveAmount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.Write("How many numbers do you want to enter? ");
int num = Convert.ToInt32(Console.ReadLine());

if(num <= 0)
{
    Console.WriteLine("Incorrect input!");
}
else
{
    int[] newArray = CreateArray(num);
    Console.WriteLine("You entered " + ShowPositiveAmount(newArray) + " positive numbers");
}
*/

//**********************************************************************************************

/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

/*
string TransformDecToByn(int num)
{
    string byn = String.Empty;
    int temp;
    while (num > 0)
    {
        temp = num;
        byn = Convert.ToString(temp % 2) + byn;
        num = num / 2;
    }
    return byn;
}

Console.Write("Enter a decimal number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <=0 )
{
    Console.WriteLine("Incorrect input!");
}
else
{
    Console.WriteLine("decimal " + number + " is bynary " + TransformDecToByn(number));
}
*/

//**********************************************************************************************

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

/*
void GetInterseptionPoint(double b1, double k1, double b2, double k2)
{
    if(k1 == k2)
    {
        Console.WriteLine("There is no intersection point. Lines are parallel to each other");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.WriteLine("The interception point is (" + x + "; " + y + ")");
    }
}

Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

GetInterseptionPoint(b1, k1, b2, k2);
Console.WriteLine();
*/