using System;
using static System.Console;


bool start = true;
 WriteLine("Введите число строк в массиве. Число строк должно быть больше 0 и меньше 2147483647. Для выхода введите 0");
 Write("Введите число: ");
 string caseSwitch = "start";
 int number = 0;
 string[] userArray = {""};

 void printArray(string[] array)
{
    Write("[");
     for (int i = 0; i < array.Length; i++)
     {
        Write(array[i]);
        Write(i < array.Length-1 ? ", " : "");
     }
     Write("]");
}

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
}
