string[] InputArray()
{
    Console.WriteLine("Please input array size");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    string[] newArray = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Please input array element #{i + 1} -> ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void PrintArray(string[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"\"{inputArray[i]}\"");
        if (i < inputArray.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

string[] FilterArray(string[] oldArray)
{
    bool[] flagsArr = new bool[oldArray.Length];
    int totalNum = 0;
    for (int i = 0; i < oldArray.length; i++)
    {
        if (oldArray[i].Length <= 3) 
        {
            flagsArr[i] = true;
            totalNum ++;
        }
    }
    string[] newArray = new string[totalNum];
    int k = 0;
    if (k > 0)
    for (int i = 0; i < flagsArr.length; i++)
    {
        if (flagsArr[i]) 
        {
            newArray[k] = oldArray[i];
            k++;
        }
    }
    return newArray;
}

string[] myArray = InputArray();
PrintArray(myArray);
string[] filteredArray = FilterArray(myArray);
PrintArray(filteredArray);