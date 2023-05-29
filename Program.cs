// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void printNumber(int n) {
    if (n == 1)
        Console.WriteLine(n);
    else
    {
        Console.Write(n + ", ");
        printNumber(n - 1);
    }
}

Console.Write("Введите число N: ");
int numberCount = Convert.ToInt32(Console.ReadLine());

printNumber(numberCount);


// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumNumbers(int from, int to) {
    if (from == to)
        return from;
    else
        return from + sumNumbers(from + 1, to);
}

Console.Write("Введите начальное число M: ");
int numberFrom = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число N: ");
int numberTo = Convert.ToInt32(Console.ReadLine());

if (numberFrom > numberTo)
    Console.WriteLine("Начальное число не должно быть больше конечного.");
else
{
    int sum = sumNumbers(numberFrom, numberTo);
    Console.WriteLine($"Сумма чисел от {numberFrom} до {numberTo} равна {sum}");
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int funcAkkerman(int n, int m) {
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return funcAkkerman(n - 1, 1);
        else
            return funcAkkerman(n - 1, funcAkkerman(n, m - 1));
}

Console.Write("Введите неотрицательное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
    Console.WriteLine("Числа должны быть неотрицательными.");
else
    Console.WriteLine($"Функция Аккермана А({numberN}, {numberM}) = {funcAkkerman(numberN, numberM)}");

