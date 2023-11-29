// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Dz66(int M, int N)
{
    int SumElem(int M, int N, int sum)
    {
        if (M == N)
        {
            sum += M;
            Console.WriteLine(sum);
            return sum;
        }
        else
        {
            sum += M;
            M ++;
            SumElem(M, N, sum);
            return sum;
        }
           
    }
    int sum = 0;
    Console.Write($"M = {M}; N = {N} -> ");
    SumElem(M, N, sum);
    return sum;
}


Console.WriteLine("");
Console.WriteLine("Задача №66:");
Dz66(4, 8);