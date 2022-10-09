# nullable disable
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
    Console.Write("-> [");
    if (newArray.Length == 0)
    {
        Console.WriteLine(" ]");
    }
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == newArray.Length - 1)
        {
            Console.WriteLine($"{newArray[i]}] ");
        }
        else
        {
            Console.Write($"{newArray[i]}, ");
        }
    }
}

Console.WriteLine("Введите любые строки через запятую: ");
string text = Console.ReadLine();
text = text.Replace(" ", "");
string[] array = text.Split(",");

string[] resNewArray = CreateNewArray(array);
string[] resSearch = SearchLengthString(array, resNewArray);
PrintNewArray(resSearch);
