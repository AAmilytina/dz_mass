// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.
// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

double[] FillArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();

    for (int i=0; i<array.Length; i++)
    {
        double randomAr = Math.Round (random.NextDouble()*10,2);
        array[i] = randomAr;
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i=0; i<array.Length; i++)
    {
    Console.WriteLine(array[i] + " ");
    }
    Console.Write();
}

void DifAr(double[]arr)
{
    double min = arr[0];
    double max = arr[0];
        foreach (double num in arr)
    {
        if (num > max)
            max = num;

        if (num<min)
            min = num;
    }
double DifAr = max - min;

Console.WriteLine($"{DifAr}");
}
double lengthArray = 5;
double[] arr = FillArray(lengthArray);
PrintArray(arr);

// не могу, никак не получется...