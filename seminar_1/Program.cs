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

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int i = -number;
// while(i<=number)
//{
//System.Console.Write(i + " ");
//i++; // <= это аналог конструкции i = i + 1
//}
//System.Console.WriteLine();

// ОТДЕЛЬНО РЕШЕНИЕ ЧЕРЕЗ "FOR" 
for(int i = -number; i <=number; i++)
    System.Console.Write(i + " ");
// если нужно сделать больше одного дейсвия необходимо 
// прописывать через контекст {}

