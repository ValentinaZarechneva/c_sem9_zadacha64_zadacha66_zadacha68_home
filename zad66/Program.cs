// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NumberSum (int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма чисел в промежутке от m до n: {sum}"); 
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
NumberSum(m, n, 0);


