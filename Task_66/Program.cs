// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Подсчёт суммы натуральных значений в указанном диапазоне m...n
uint SumRangeNaturalValues(uint m, uint n)
{
    if (m == n)
        return m;
    else if (m < n)
    {
        return m + SumRangeNaturalValues(m + 1, n);   
    }
    else
    {
        return n + SumRangeNaturalValues(n + 1, m);
    }
}

Console.WriteLine("Введите натуральное число M:");  
uint m;
while (!uint.TryParse(Console.ReadLine(), out m) || m <= 0)
{
    Console.WriteLine("Некорректное значение!");
    Console.WriteLine("Введите натуральное число M:");              
} 

Console.WriteLine("Введите натуральное число N:");  
uint n;
while (!uint.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Некорректное значение!");
    Console.WriteLine("Введите натуральное число N:");              
}  

Console.WriteLine($"Сумма натуральных элементов от {m} до {n}: {SumRangeNaturalValues(m, n)}");