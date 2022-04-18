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
    num = num / 10 % 10;
    return num;
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

