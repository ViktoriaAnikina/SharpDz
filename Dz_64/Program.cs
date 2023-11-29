// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int Dz64 (int N)
{
    
    if (N == 1)
    {
        Console.WriteLine(N);
        return N;
    }
    Console.Write(N + ", ");
    N += -1;
    Dz64(N);
    return N;
}


int N = 8;
Console.WriteLine("Задача №64:");
Console.Write($"N = {N} -> ");
Dz64(N);