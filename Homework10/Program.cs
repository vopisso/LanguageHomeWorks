/*
Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
*/

/*
int CountStartVowel(string[] array)
{
    char[] vowelLetters = {'a', 'e', 'i', 'o', 'u', 'y'};
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < vowelLetters.Length; j++)
        {
            if(array[i][0] == vowelLetters[j])
            {
                counter++;
            }
        }
    }
    return counter;
}

string[] words = {"eye", "qwe", "wer", "ert", "rty", "tyu", "art"};

Console.Clear();
Console.WriteLine("Number of words that start with a vowel: " + CountStartVowel(words));
Console.WriteLine();
*/

// *******************************************************************************************

/*
Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, 
объединяя элементы исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/

/*
string[] CombineWords(string[] array)
{
    string[] CombinedArray = new string[array.Length / 2];
    for (int i = 0, j = 0; i < CombinedArray.Length; i++, j += 2)
    {
        CombinedArray[i] = array[j] + array[j + 1];
    }
    return CombinedArray;
}

void PrintArrayString(string[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write('"' + array[i] + '"');
        if(i == array.Length - 1)
        {
            Console.Write("}");
        }
        else
        {
            Console.Write(", ");
        }
    }
}

string[] words = {"qwe", "rty", "sam", "sung", "home", "work", "super", "natural"};

Console.Clear();
PrintArrayString(words);
string[] newArray = CombineWords(words);
Console.Write("  ->  ");
PrintArrayString(newArray);
Console.WriteLine("\n");
*/