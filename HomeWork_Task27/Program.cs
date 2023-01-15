/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("ввели не число или меньше 1.");
        }
    }

    return result;
}

int GetSumm(int number)
{
    int summ = 0;

    while (number != 0)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}

int number = GetNumber("Введите число больше 1");
int summ = GetSumm(number);

Console.WriteLine($"Сумма цифр в числе {number} = {summ}");