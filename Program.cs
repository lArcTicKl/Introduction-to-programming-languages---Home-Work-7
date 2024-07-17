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

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return Akkerman(M - 1, 1);
    else return Akkerman(M - 1, Akkerman(M, N - 1));

}

Console.WriteLine("Input natural number 'M' for function Akkerman: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input natural number 'N' for function Akkerman: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0)
{
    Console.WriteLine("Both M and N must be non-negative integers.");
}
else
{
    Console.WriteLine(Akkerman(M, N));
}