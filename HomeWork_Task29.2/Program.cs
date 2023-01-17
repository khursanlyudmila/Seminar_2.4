/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

Console.WriteLine("Будет создан массив длиной A в диапозоне 0-A");
Console.Write("Введите любое число (A): ");
int enterNumber;
enterNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[enterNumber];

for (int i = 0; i < enterNumber; i++)
{
    array[i] = new Random().Next(enterNumber+1);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();

