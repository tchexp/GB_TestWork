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



PrintArray(InputArray());