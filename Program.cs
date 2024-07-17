// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void PrintMToN(int M, int N)
{
    if (M <= N - 2)
    {
        Console.Write(M + 1 + " ");
        PrintMToN(M + 1, N);
    }
}

Console.WriteLine("Введите начальное число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе начальное число, которое будет больше {A}: ");
int B = Convert.ToInt32(Console.ReadLine());

PrintMToN(A, B);