// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью 
// рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return  Convert.ToInt32(ReadLine());
}
string printNumbers(int start,int end)
{
    if (start==end) return start.ToString ();
    return (start + " " + printNumbers (start - 1, end));
}

int n = ReadFromConsole("Введите значение n");
int m =1;
WriteLine(printNumbers(n,m));
