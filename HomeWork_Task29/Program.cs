/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

все 8 элементов должны получить за один Console.ReadLine();
подсказка: использовать потом метод string.Split();
*/

Console.WriteLine("Необходимо ввести массив из 8 элементов, например: 1, 2, 3, 4, 5, 6, 7, 8");
Console.WriteLine("Введите массив: ");

String str = Console.ReadLine();
  
String[] spearator = {", ", ". "};
Int32 count = 8;
  
String[] strlist = str.Split(spearator, count,
    StringSplitOptions.RemoveEmptyEntries);
  
foreach(String s in strlist)
{
    Console.WriteLine(s);
}


