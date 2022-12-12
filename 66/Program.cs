// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using static System.Console;
Clear(); 

int summ=0;
int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return  Convert.ToInt32(ReadLine());
}
int printNumbers(int start,int end)
{
    if (start==end) return summ=summ+start;
    summ = start +  printNumbers (start + 1, end);
    return summ;
}

int n = ReadFromConsole("Введите значение n");
int m = ReadFromConsole("Введите значение m");


if (n > m ) {summ = printNumbers(m,n);}
else {summ = printNumbers(n,m);}
WriteLine (summ);