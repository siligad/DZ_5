/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/


double [] ArrayFill(double[] array)
{
    int size;
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(100, 10000)/100.00;
    }
    return array;
}

void ArrayShow(double[] array)
{
    int size;
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
         Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}

double ArrayDiff(double[] array)
{
    int size;
    double max=array[0];
    double min=array[1];
    double diff;
    size = array.Length;
    /*if (max<min)
        {
            max=array[1];
            min=array[0];
        }
    */
    for (int i = 0; i < size; i++)
    {
         if (array[i]>max)
         {
            max=array[i];
         }
         else
         {
            if (array[i]<min)
            {
                min=array[i];
            }
         }
    }
    diff=max-min;
    return diff;
}

int size=4;
double[] array=new double[size];
double diff;
array=ArrayFill(array);
ArrayShow(array);
diff=ArrayDiff(array);
diff=Math.Round(diff,2);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diff}");