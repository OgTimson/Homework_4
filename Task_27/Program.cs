/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или число меньше 0. Повторите ввод!");
        }
    }

    return result;
}

int GetSum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }

    return sum;
}

int number = GetNumber("Введите положительное число");
int sumDigit = GetSum(number);

Console.WriteLine($"Сумма цифр в числе {number} = {sumDigit}");