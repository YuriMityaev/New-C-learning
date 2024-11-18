// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Напишите программу, которая на вход
//принимает два целых числа и проверяет,
//является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет


//Console.Write("Введите число: ");
//int firstNmber = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());

//if (firstNmber == secondNumber*secondNumber)
//{
//    Console.WriteLine("Да");
//}
//else
//{
//    Console.WriteLine("Нет");
//}


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// УПРОЩЕННЫЙ ВАРИАНТ УКАЗАНИЯ ПЕРЕМЕННОЙ ПРИ ВЫВОДЕ СТРОКИ
// Console.WriteLine($"{number} + 10");

//Задание 2. Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры

// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
//2 => -2, -1, 0, 1, 2

//  Console.Write("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int i = -number;
// while(i<=number)
//{
//System.Console.Write(i + " ");
//i++; // <= это аналог конструкции i = i + 1
//}
//System.Console.WriteLine();

// ОТДЕЛЬНО РЕШЕНИЕ ЧЕРЕЗ "FOR" 
// for(int i = -number; i <=number; i++)
//    System.Console.Write(i + " ");
// если нужно сделать больше одного дейсвия необходимо 
// прописывать через контекст {}

//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.
//456 => 10
//782 => 9
//918 => 17

// Console.Write("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// if (number > 99 && number < 1000) // && - означает что оба условия должны выполняться одновременно.
//{
//    System.Console.WriteLine(number / 100 + number % 10);
// }
// else
// {
//    System.Console.WriteLine("Введите повторно ТРЕХЗНАЧНОЕ число.");
//}

// Домашнее задание:
// Задача 0: 

// Console.Write("Введите первое число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// Console.Write("Введите первое число: ");
// int number2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// if (number < number2)
// {
// System.Console.WriteLine("Второе число больше");
// }
// else
// {
//    System.Console.WriteLine("Первое число больше");
// }

// Задача 1: ( НЕ РЕШЕНА)
// Jпределите, делится ли число на другое
// Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".

//Console.Write("Введите первое число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// Console.Write("Введите первое число: ");
//int number2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// System.Console.WriteLine(number / number2); // конструкция просто для просмотра введенных переменных.
// System.Console.WriteLine(number % number2); // конструкция просто для просмотра введенных переменных.

// if ((number % number2) > 0)
// {
// System.Console.WriteLine("не делится");
// }
// else
//{
// System.Console.WriteLine("делится");
// }

// Задача № 2. 

// Нужно ввести три числа и вернуть среднее из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

//int max = a;
//int min = b;
//if (b > max)
//{
  //  max = b;
//}
//if (c > max)
//{
  //  max = c;
//}

//if (a < min)
//{
  //  min = a;
//}
//if (c < min)
//{
  //  min = c;
//}

//Console.WriteLine("Минимальное число " + min);
//Console.WriteLine("Максимальное число " + max);

//int middlenumber = a + b + c - min - max;
//System.Console.WriteLine("Число со средним значением " + middlenumber);

// подсмотренное решение в  описании задания ниже 
//(даже обидно что тоже работает и похоже на то, что хотел 
//сделать изначально, но не совсем продумал 
//как именно это сделать):

if ((a >= b && a <= c) || (a >= c && a <= b))
{
System.Console.WriteLine(a);
}
else if ((b >= a && b <= c) || (b >= c && b <= a))
{
System.Console.WriteLine(b);
}
else
{
System.Console.WriteLine(c);
}