
string[] CreateNewArray(string[] array)
{
    int newLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newLength++;
    }
    string[] newArray = new string[newLength];
    return newArray;
}


string[] SearchLengthString(string[] array, string[] newArray)
{
    int i = 0;
    while (i < newArray.Length)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length <= 3)
            {
                newArray[i] = array[j];
                i++;
            }
        }
    }
    return newArray;
}


void PrintNewArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
        Console.WriteLine($"{newArray[i]} ");
}

Console.WriteLine("Введите строки через запятую: ");
string textArray = Console.ReadLine();

string[] array = textArray.Split(",");
string[] result1 = CreateNewArray(array);
string[] result2 = SearchLengthString(array, result1);
PrintNewArray(result2);
