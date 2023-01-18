/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Write("Введите размер массива: ");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];
Console.WriteLine();
Console.Write("Массив - ");
for (int i = 0; i < a; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int[] newarray = new int[(a + 1) / 2];
for (int i = 0; i < newarray.Length; i++)
{
    newarray[i] = array[i] * array[a - i - 1];
}
Console.Write("Результат - ");
for (int i = 0; i < newarray.Length; i++)
{
    Console.Write(newarray[i] + " ");
}
