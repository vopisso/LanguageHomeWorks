/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int GetSecondNum(int num)
{
    return num / 10 % 10;
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number <= 999)
{
    Console.WriteLine(number + " -> " + GetSecondNum(number));
}
else if(number >= -999 && number <= -100)                       // проверка на случай, если число отрицательное
{
    int a = -1 * number;                                        // для вывода в консоль -456 -> 5  
    Console.WriteLine(number + " -> " + GetSecondNum(a));
}
else
{
    Console.WriteLine("Incorrect input!");
}
*/

//****************************************************************************************************

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int GetThirdNum(int num)
{
    while(num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
   Console.WriteLine(number + " -> " + GetThirdNum(number));
}
else if(number < -99)
{
    int a = -1 * number;
    Console.WriteLine(number + " -> " + GetThirdNum(a));
}
else
{
    Console.WriteLine("There is no third digit in the number");
}
*/

//****************************************************************************************************

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
void CheckDay(int dayNum)
{
    if(dayNum >= 1  && dayNum <= 5)
    {
        Console.WriteLine(dayNum + " -> working day");
    }
    else if(dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine(dayNum + " -> day off");
    }
    else
    {
        System.Console.WriteLine("Only 7 days in a week!");
    }
}

Console.Write("Input day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckDay(dayNumber);
*/