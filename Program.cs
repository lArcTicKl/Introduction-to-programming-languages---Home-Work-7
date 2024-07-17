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

// int Akkerman(int M, int N)
// {
//     if (M == 0) return N + 1;
//     else if (N == 0) return Akkerman(M - 1, 1);
//     else return Akkerman(M - 1, Akkerman(M, N - 1));
// }

// Console.WriteLine("Input natural number 'M' for function Akkerman: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input natural number 'N' for function Akkerman: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (M < 0 || N < 0)
// {
//     Console.WriteLine("Both M and N must be non-negative integers.");
// }
// else
// {
//     Console.WriteLine(Akkerman(M, N));
// }


// -----------------------------------------------------------------
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

char GetRandomChar()
{
    Random rand = new Random();
    int i = rand.Next(0, 4);
    char RndChar;

    if (i == 0) RndChar = (char)rand.Next('a', 'z' + 1);
    else if (i == 1) RndChar = (char)rand.Next('A', 'Z' + 1);
    else if (i == 2) RndChar = (char)rand.Next('!', '?' + 1);
    else RndChar = (char)rand.Next('0', '9' + 1);
    return RndChar;
}

char[] CreateRandomArrayOfChar(int size)
{
    char[] array = new char[size];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = GetRandomChar();
    }
    return array;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintArrayReverse(char[] array, int i)
{
    if (i > 0)
    {
        Console.Write(array[i - 1] + " ");
        PrintArrayReverse(array, i - 1);
    }
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

char[] array = CreateRandomArrayOfChar(size);
PrintArray(array);
PrintArrayReverse(array, array.Length);

// В третьем задании мне хотелось продемонстрировать своё решение, по заполнению массива случайными символами.
// Понимаю, что конструктор Random находится внутри цикла, в функции CreateRandomArrayOfChar и связанный с ним GetRandomChar,
// но как брать символ из таблицы символов, я не нашел. Хотелось бы получить ваш комментарий по этому вопросу.