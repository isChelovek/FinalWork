using System;
using static System.Console;


bool start = true;
 WriteLine("Введите число строк в массиве. Число строк должно быть больше 0 и меньше 2147483647. Для выхода введите 0");
 Write("Введите число: ");
 string caseSwitch = "start";
 int number = 0;
 string[] userArray = {""};


string[] findThreeLengthRow(string[] inputArray) // метод поиска строк меньше или равное трем
{
    string[] temp = new string[inputArray.Length]; // создаем времменый массив, пока не известно колливо элементов меньше трех
    int count = 0;
    for (int i = 0; i < inputArray.Length; ++i)
    {
        if (lengthString(inputArray[i]) <= 3)
        {
           temp[count] = inputArray[i];
           ++count;
        }
    }
    string[] outputArray = new string[count]; // создаем массив нужной длины
    for (int i = 0; i < count; i++)
    {
        outputArray[i] = temp[i];
    }
    return outputArray;
} // findThreeLengthRow
 
void printArray(string[] array)
{
    Write("[");
     for (int i = 0; i < array.Length; i++)
     {
        Write(array[i]);
        Write(i < array.Length-1 ? ", " : "");
     }
     Write("]");
} // printArray

int lengthString (string inputString) // Подсчет символов в строке
{
    int count = 0;
    if (inputString != "")
    {
        foreach (var item in inputString)
        {
            ++count;
        }
    }
    return count;
} // lengthString
