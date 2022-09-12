int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
} 

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPisition = i;

        for(int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPisition]) minPisition = j;
    }

        int temporary = array[i];
        array[i] = array[minPisition];
        array[minPisition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);

PrintArray(arr);

