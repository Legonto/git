﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// * -------------------РЕШЕНИЕ-------------------------- *

// Console.WriteLine ("Задача 2. В этой программе мы сравним два целых числа и покажем какое из них больше, а какое меньше");
// Console.WriteLine ("Введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numA>numB)
// {
//     Console.WriteLine ("Большее число: " + numA + ", меньшее число: " + numB);
// }
// if (numA==numB)
// {
// Console.WriteLine ("Вы ввели два одинаковых числа");
// }
// else 
// {
//     Console.WriteLine ("Большее число: " + numB + ", меньшее число: " + numA);
// }


// *--------------------------------------------------------------------------------*


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// * ---------------------------РЕШЕНИЕ------------------------------ *

Console.WriteLine ("Задача 4. В этой программе мы сравним три целых числа и покажем какое из них больше");

Console.WriteLine ("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int numС = Convert.ToInt32(Console.ReadLine());
int max = numA;

if (max<numB)
{
    int max = numB;
}
if (max<numC)
{
    int max = numС;
}

    Console.WriteLine ("Большее число: " + max);
