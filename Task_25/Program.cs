/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int GetExp(int A, int B)
{
    int exp = 1;

    for (int i = 1; i <= B; i++) // здесь цикл возведения A в степень B по условию 
    {                            // в задаче (можно было и без него обойтись:))
        exp *= A;
    }

    return exp;
}

int numA = GetNumber("Введите число A (больше 0)");
int numB = GetNumber("Введите число B (больше 0)");
int expo = GetExp(numA, numB);

Console.WriteLine($"Число {numA} в натуральной степени {numB} = {expo}");