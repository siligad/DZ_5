/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] ArrayFill(int[] array)
{
    int size;
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(100);
    }
    return array;
}

void ArrayShow(int[] array)
{
    int size;
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
         Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}

int ArrayOdd(int[] array)
{
    int size;
    int count=0;
    size = array.Length;
    for (int i = 0; i < size; i=i+2)
    {
        count=count+array[i];
    }
    return count;
}

int size=4;
int[] array=new int[size];
int odd;
array=ArrayFill(array);
ArrayShow(array);
odd=ArrayOdd(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве: {odd}");