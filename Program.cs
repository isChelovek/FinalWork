﻿using System;
using static System.Console;

bool startProg = true;
WriteLine("Введите число строк в массиве. Число строк должно быть больше 0 и меньше 2147483647. Для выхода введите 0");
WriteLine("Для выхода введите 0");
Write("Введите число: ");
 string caseSwitch = "Start";
 int numWords = 0;
 string[] userArray = {""};

while (startProg)
{
    switch (caseSwitch)
    {
        case "Start": // Обработка пользовательского ввода
            numWords = checkUserNum(ReadLine());
            if (numWords == -1) // Если ввели не коректное число
            {
              break;  
            }
            if (numWords == 0)
            {
                WriteLine("Прощайте");
                caseSwitch = "exit";
                break;
            }     
            caseSwitch = "AddWords";
            break;    
        case "AddWords": // Заполнение пользовательского массива
        
            userArray = new string[numWords];
            for (int i = 0; i < numWords; i++)
            {
                WriteLine($"Веедите слово номер {i+1}");
                userArray[i] = ReadLine();
            }
            caseSwitch = "findElements";  
        break;
        case "findElements": // Обработка результатов
        string[] resultArray = findThreeLengthRow(userArray);
        printArray(userArray); 
        Write(" -> ");
        if (resultArray.Length == 0) 
        {
            WriteLine("В массиве нет слов длинной меньше и равных трем сиволам");
            caseSwitch = "exit";
        }
        else
        {
            printArray(resultArray);
            caseSwitch = "exit";
        }
        break;
        case "exit":
            startProg = false;
        break;
        default:
            startProg = false;
        break;
    }
} // Main while

int checkUserNum (string text)
{
    bool start = true;
    int result = -1; // Магическое число обозначающе неправильный ввод
    while (start)
    {
        if (!int.TryParse(text, out result))
        {
            WriteLine("Не удалось распознать число, попробуйте еще раз.");
            return -1;
        }
        if (result > int.MaxValue)
        {
            WriteLine("Вы ввели слишком большое число. Попробуйте еще раз");
            return -1;
        }
        if (result < 0)
        {
            WriteLine("Вы ввели отрицательное число. Попробуйте еще раз");
            return -1;
        } 
        start = false;
    }
    return result;
}

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
