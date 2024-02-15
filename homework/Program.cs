// task1
/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
 в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/



void ShowNumbers (int start, int end)
{
    // Базовый случай
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    // Рекурсивный случай
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

ShowNumbers(M, N); // start = M, end = N