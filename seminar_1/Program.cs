// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Напишите программу, которая на вход
//принимает два целых числа и проверяет,
//является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет
Console.Write("Введите число: ");
int firstNmber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNmber == secondNumber*secondNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number +10);