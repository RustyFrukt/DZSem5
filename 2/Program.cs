/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] Array(int size, int minValue, int MaxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, MaxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int SumPNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = -99;
int maxValue = 99;
int[] array = Array(size, minValue, maxValue);
int result=SumPNumber(array);
ShowArray(array);
Console.Write($"Сумма элементов на нечетных индексах - {result}");