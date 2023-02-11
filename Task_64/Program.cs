// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Вывод натуральных значений
void PrintNaturalValues(uint n)
{
    if (n == 1)
        Console.WriteLine(n + " ");
    else
    {
        Console.Write(n + ", ");
        PrintNaturalValues(n - 1);
    }
}

Console.WriteLine("Введите натуральное число:");  
uint n;
while (!uint.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Некорректное значение!");
    Console.WriteLine("Введите натуральное число:");              
}  

PrintNaturalValues(n);