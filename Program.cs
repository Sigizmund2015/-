/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void ShowNumbers(int n)
{
    if(n>=1)
    {
        Console.WriteLine(n+" ");
        ShowNumbers(n-1);
    }
}
ShowNumbers(5); 


void ShowNumber(int n)
{
    if(n>=1)
    {
        Console.WriteLine(n+" ");
        ShowNumber(n-1);
    }
}
ShowNumber(8);


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
		}
		
Console.WriteLine(CalculateSumm(1, 15)); 


int CalculateSum(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
		}
		
Console.WriteLine(CalculateSum(4, 8)); 


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
Console.WriteLine(AkkermanFunc(2,3));


int AkkermanFun(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFun(m - 1, 1);
			}
			return AkkermanFun(m - 1, AkkermanFun(m, n - 1));
		}
Console.WriteLine(AkkermanFun(3,2));
