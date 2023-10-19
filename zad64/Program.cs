// Задача 64:Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Numbers(int m, int n) //запускаем метод меняет числа от m до n
{
 string result = String.Empty;
 for(int i = m; i >= n; i--)
 {
 result += $"{i} ";
 }
 return result;
}
string NumbersRec(int m, int n)//вызываем рекурсию
{
 if(m <= n) return NumbersRec(m + 1, n) + $"{m} ";
 else return String.Empty;
}
Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
Console.WriteLine(Numbers(m, n)); 
Console.WriteLine(NumbersRec(m, n));
