// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Dz68( int m, int n)
{

    if (m < 0 || n < 0)
    {
        Console.WriteLine("Числа 'm' и 'n' должны быть только положительными.");
        return -0;
    }
   
    if (m ==0)
        {
            return n+1;
        }
    else 
        if ( m > 0 && n ==0)
        {
            return Dz68(m-1, 1);
        }
         else
        {
            return Dz68(m-1, Dz68(m,n-1));
        }
        
}
Console.WriteLine("");
Console.WriteLine("Задача №68:");
Console.WriteLine(Dz68(3,2));