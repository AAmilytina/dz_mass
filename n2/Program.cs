// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] FillArray(int lengthArray)
{
    int []array = new int[10];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1,101);
    }
    return array;
}
int n = 0;
void PrintArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    { 
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
   
for (int i=0; i<array.Length; i++)
{ 
    if (array[i]%2==0)
    n = n +1;
}
}
int lengthArray = 10;
int[] arr = FillArray(lengthArray);
PrintArray(arr);

Console.WriteLine($"{n}");