//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] array = GetArray(4, 100, 999); // создали массив array, через метод GetArrray 12-размер, -9 мин число 9 макс число
Console.WriteLine(String.Join(" ", array));


for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) 
    {
        Console.Write($"Четные числа массива: {array[i]}"); 
    }
}

bool Contains(int[] arr, int find)
{
    for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == find)
    {
    return true;
    }
   
}
return false;
}


int[] GetArray(int size, int minValue, int maxValue) // Это создали функцию как элемент массива
{
    int[] res = new int[size]; // обьявил массив в котором буду работать с этим методом

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // каждый индекс заполняется рандомным числом
    }
    return res; // возвращаю заполненный массив
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] array = GetArray(8, 1, 7); // создали массив array, через метод GetArrray 12-размер, -9 мин число 9 макс число
Console.WriteLine(String.Join(" ", array));

int negativeSum = 0;

for (int i = 1; i < array.Length; i=i+2)
{
    negativeSum = negativeSum + array[i];
}
Console.WriteLine($"{negativeSum}");


int[] GetArray(int size, int minValue, int maxValue) // Это создали функцию как элемент массива
{
    int[] res = new int[size]; // обьявил массив в котором буду работать с этим методом

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // каждый индекс заполняется рандомным числом
    }
    return res; // возвращаю заполненный массив
}
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] array = GetArray(5, 1, 80); // создали массив array, через метод GetArrray 12-размер, -9 мин число 9 макс число
Console.WriteLine(String.Join(" ", array));

int max = Int32.MinValue;
int min = Int32.MaxValue;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    if(array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"max is {max}, min is {min}");
Console.WriteLine($"difference is {max - min}");


int[] GetArray(int size, int minValue, int maxValue) // Это создали функцию как элемент массива
{
    int[] res = new int[size]; // обьявил массив в котором буду работать с этим методом

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); // каждый индекс заполняется рандомным числом
    }
    return res; // возвращаю заполненный массив
}