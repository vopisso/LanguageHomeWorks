/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
void CheckPalindrom(int num)
{
    int n1 = num / 10000 % 10;
    int n2 = num / 1000 % 10;
    int n4 = num / 10 % 10;
    int n5 = num % 10;

    if(num < 10000 || num > 99999)
    {
        Console.WriteLine("Incorrect input!");
    }
    else if(n1 == n5 && n2 == n4)
    {
        Console.WriteLine("The number " + num + " is a palindrome");
    }
    else
    {
        Console.WriteLine("The number " + num + " is NOT a palindrome");
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

CheckPalindrom(number);
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
double GetSegmentLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double segmentX = xB - xA;
    double segmentY = yB - yA;
    double segmentZ = zB - zA;
    double segmentAB = Math.Sqrt((segmentX * segmentX) + (segmentY * segmentY) + (segmentZ * segmentZ));
    return segmentAB;
}

Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB ");
double zB = Convert.ToDouble(Console.ReadLine());


double aB = GetSegmentLength(xA, yA, zA, xB, yB, zB);
Console.WriteLine("segment A (" + xA + "," + xB + "," + zA + ")" + "; B (" + yA + "," + yB +
                  "," + zB + ")" + " length -> " + aB);
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
void GetCubesOfNumber(int num)
{
    int count = 1;
    int a;
    Console.Write(num + " -> ");
    while(count <= num)
    {
        a = Convert.ToInt32(Math.Pow(count, 3));
        Console.Write(a);
        if(count < num) Console.Write(", ");
        count++;
    }

}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("Incorrect input");
}
else
{
    GetCubesOfNumber(number);
}
*/