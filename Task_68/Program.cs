// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Функция Аккермана
uint Ackermann(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);   
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Console.WriteLine("Для функции Аккермана A(m, n)\nвведите аргумент m:");  
uint m;
while (!uint.TryParse(Console.ReadLine(), out m))
    Console.WriteLine("Некорректное значение!\nвведите аргумент m:");          

Console.WriteLine("введите аргумент n:");  
uint n;
while (!uint.TryParse(Console.ReadLine(), out n))
    Console.WriteLine("Некорректное значение!\nвведите аргумент n:");             

Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");