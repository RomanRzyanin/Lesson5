// task1
/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
 в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

/// <summary>
/// Метод печатает все целые числа от M до N
/// </summary>
/// <param name="start"> точка начала, M </param>
/// <param name="end"> точка остановки, N </param>
// void ShowNumbers (int start, int end)
// {
//     // Базовый случай
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     // Рекурсивный случай
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }
// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// ShowNumbers(M, N);

//task2
/*Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

/// <summary>
/// Метод вычисляющий функцию Аккермана
/// </summary>
/// <param name="n"> первый параметр функции Аккермана </param>
/// <param name="m"> второй параметр функции Аккермана </param>
/// <returns> Результат вычисления Функции Аккермана</returns>
// double GetAckermanFunction(int n, double m)
// {
//     //Базовый случай
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     // Рекурсивный случай
//     else if (m == 0)
//     {
//         return GetAckermanFunction(n - 1, 1);
//     }
//     else
//     {
//         return GetAckermanFunction(n - 1, GetAckermanFunction(n, m - 1));
//     }
// }
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Функция Аккермана ({n}, {m}) = {GetAckermanFunction(n, m)}");

//task3
/*Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

/// <summary>
/// Метод печатает элементы архива в обратном порядке.
/// </summary>
/// <param name="array"> архив </param>
/// <param name="j"> индекс последнего элемента архива </param>
void PrintReverseArray (int[] array, int j)
{
    //Базовый случай
    if (j == 0)
    {
        Console.Write($"{array[j]} ]");
        return;
    }
    //Рекурсивный случай
    Console.Write($"{array[j]}, ");
    PrintReverseArray(array, j - 1);
}
int[] array = { 2, 3, 6, 33, 57, 0, 45, 667, 89, 5, 11 };
int l = array.Length - 1;
Console.Write("[ ");
PrintReverseArray(array, l);
