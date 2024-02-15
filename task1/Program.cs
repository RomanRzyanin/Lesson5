// // task1

double GetFact(int n)
{
    if (n == 1 || n == 0)
    {
        //Console.WriteLine($"Stop:{n}");
        return 1;
    }
    //Console.WriteLine(n);
    return n * GetFact(n - 1);
    
}
Console.Write(GetFact(123));

// void OpenMatryoshka(int size)
// {
//     Console.WriteLine($"Opening matryoshka of size {size}...");
//     if (size == 1)
//     {
//         Console.WriteLine($"Reached the smallest matryoshka!");
//         return;
//     }
//     OpenMatryoshka(size - 1);
//     //Console.WriteLine($"Opening matryoshka of size {size}...");
// }
// OpenMatryoshka(5);