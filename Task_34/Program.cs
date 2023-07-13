/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] ArrayFill(int[] array)
{
    int size;
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(100, 1000);
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

int ArrayEven(int[] array)
{
    int size;
    int coun=0;
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
         if (array[i]%2==0)
         coun++;
    }
    return coun;
}

int size=4;
int[] array=new int[size];
int even;
array=ArrayFill(array);
ArrayShow(array);
even=ArrayEven(array);
Console.WriteLine($"Число чётных чисел в массиве: {even}");