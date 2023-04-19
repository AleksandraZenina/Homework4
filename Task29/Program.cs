// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] CreateRandomArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,101);
    }
    return array;
}

void PrintArray (int [] array)
{   
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int size = 8;
int[] arr = CreateRandomArray(size); 
PrintArray(arr);

