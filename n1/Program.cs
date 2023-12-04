// //Задача 1: Задайте одномерный массив из 10 целых
// чисел от 1 до 100. Найдите количество элементов
// массива, значения которых лежат в отрезке [20,90].


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
    if ((array[i]>20) && (array[i]<90))
    n = n +1;
}
}
int lengthArray = 10;
int[] arr = FillArray(lengthArray);
PrintArray(arr);

Console.WriteLine($"{n}");

