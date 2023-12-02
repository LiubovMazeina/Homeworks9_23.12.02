//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void OneToN(int n, int a)
// {
//     if(n != a)
//     {
//         OneToN(n, a+1);
//         System.Console.Write(a +" ");
//     }
//     else System.Console.Write(n+" ");
// }

// System.Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = 1;

// OneToN(n,a);


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int a, int b)
// {
//     if(a!=b)
//     {
//         if(b>0)
//         {
//             return FindSum(a, b-1)+b;
//         }
//         else return a;
//     }
//     else return a;
// }

// System.Console.Write("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindSum(a,b));


//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AkkermanFunc(int m, int n)
// 		{
// 			if(m == 0)
// 			{
// 				return n + 1;
// 			}
// 			if(m > 0 && n == 0)
// 			{
// 				return AkkermanFunc(m - 1, 1);
// 			}
// 			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// 		}
		

// System.Console.Write("Введите первое число ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(AkkermanFunc(m,n));
