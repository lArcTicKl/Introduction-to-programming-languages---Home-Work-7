// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// void PrintMToN(int M, int N)
// {
//     if (M <= N - 2)
//     {
//         Console.Write(M + 1 + " ");
//         PrintMToN(M + 1, N);
//     }
// }

// Console.WriteLine("Введите начальное число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите второе начальное число, которое будет больше {A}: ");
// int B = Convert.ToInt32(Console.ReadLine());

// PrintMToN(A, B);


//----------------------------------------------------------------
//Задача 2: Напишите программу вычисления функции Аккермана
//с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));

}

Console.WriteLine(Akkerman(3, 11));