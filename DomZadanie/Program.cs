// Task 34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
void InputArray( int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int PlusNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива:" );
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] - {PlusNumb(array)}");

*/

// Task 36

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
void InputArray( int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int PlusNumb(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        count += array[i];
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива:" );
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] - {PlusNumb(array)}");
*/

// Task 38

// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.57, 7.96, 22.47, 2.12, 78.73] -> 76.61
/*
void InputArray( double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(-99, 100 ) / 10.0);
}

double MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double el in array)
    {
        if(el > max ) max = el;
        else if (min > el) min = el;
    }
    return max - min; 
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива:" );
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);

Console.WriteLine($"[{string.Join("; ", array)}] -> {Math.Round(MaxMin(array), 2)}");
*/

// Статистика Васи)

void InputArray( int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32 );
}
void YesNo(int[] array)
{
    int count = 0;
    int count2 = 0;
        foreach (int el in array)
    {
        if(el % 2 == 0 ) count +=1;
        
        else if (el % 2 == 1) count2 +=1;
    }
    if (count > count2) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
void Chet(int[] array)
{
    foreach (int el in array)
    {
        if(el % 2 == 0)
        Console.Write($"{el } ");
    }
}
void NeChet(int[] array)
{
    foreach (int el in array)
    {
        if(el % 2 == 1)
        Console.Write($"{el } ");
    }
}
Console.Clear();
Console.WriteLine("Введите количество дней с оценками: " );
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
NeChet(array);
Console.WriteLine();
Chet(array);
Console.WriteLine();
YesNo(array);