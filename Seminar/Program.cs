// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
/*

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
    int summaPositive = 0, summaNegative = 0;
    foreach (int element in array)  // цикл foreach проходит каждый элемент массива!
    {
        if (element > 0)
            summaPositive += element;
        else
            summaNegative += element;
    }
    Console.WriteLine($"Сумма положительных чисел равна: {summaPositive}");
    Console.WriteLine($"Сумма отрицательных чисел равна: {summaNegative}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);

//task32

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1); // array[i] = array[i] * (-1);
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Новый массив: [{string.Join(", ", array)}]");

*/

// task 33
/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


string ReleaseArray(int[] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
            return "yes";
    }
    return "no";
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число, которое Вы ищите внутри массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, number));

*/ 
/*
// task35

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-9, 9]
}


int ReleaseArray(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element >= 10 && element <= 99)
            count++; // count = count + 1;
    }
    return count;
}

Console.Clear();
int[] array = new int[123];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
*/

// Task37
/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.WriteLine($"{array[i] * array[array.Length - i - 1]}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);

*/