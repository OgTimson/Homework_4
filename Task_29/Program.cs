/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] originalArray = { 1, 2, 5, 7, 19, 6, 1, 33 };
int[] firstArray = new int[5];
int[] secondArray = new int[3];

for (int i = 0; i < originalArray.Length; i++)
{
    if (i < 5)
    {
        firstArray[i] = originalArray[i];
    }
    else
    {
        secondArray[i - 5] = originalArray[i];
    }
}
Console.WriteLine("Первые 5 элементов массива из 8 элементов:");
Console.WriteLine("[" + String.Join(", ", firstArray) + "]");
Console.WriteLine("\nПоследние 3 элемента массива из 8 элементов:");
Console.WriteLine("[" + String.Join(", ", secondArray) + "]");