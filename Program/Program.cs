﻿
string[] CreateNewArray(string textArray)
{

    string[] array = textArray.Split(",");

    int newLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newLength++;
    }
    string[] newArray = new string[newLength];
    return newArray;
}
Console.WriteLine("Введите строки через запятую: ");
string textArray = Console.ReadLine();
string[] res = CreateNewArray(textArray);
