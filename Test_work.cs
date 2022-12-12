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





