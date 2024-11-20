// Пишем программу принимающую трехзначное число, 
// и удаляющую вторую цифру этого числа
// Например:
// а = 256 => 26


// Console.Write("Введите трехзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if(number >99 && number <1000)
//{
 //   int leftdigit = number / 100;
  //  int rightdigit = number % 10;
    //System.Console.WriteLine(leftdigit + "" + rightdigit); вариант 1 
// int result = leftdigit*10 + rightdigit; вариант 2
//System.Console.WriteLine(result); Вариант 2
// }
//else
//{
  //  System.Console.WriteLine("Введено не трехзначное число");
// }

// Задача № 2 - Ввести трехзначную цифру и
 // возвести 2ую цифру числа в степень 3ей цифры числа.

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number >99 && number <1000)
// {
//     int middledigit = ((number / 10) % 10);
//     int rightdigit = number % 10; 
//     int result = 1;
// for ( int i = 0; i < rightdigit; i++) 
//     {
//         result *= middledigit;
//     }
// System.Console.WriteLine(result);
// }
// else
// {
//     System.Console.WriteLine("Введено не трехзначное число");
// }


// Console.Write("Введите первое число число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первое число число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 == 0)
// {
// System.Console.WriteLine("YES");
// }
// else
// {
// System.Console.WriteLine("No," + number1 % number2);
// }

// Ввести число и отобразить на 3 с конца в 1 варианте 
// и 3 с начала во 2 варианте.

// Вариант решения №1 
// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if (number1 > 99)
// {
//     System.Console.WriteLine(number1 % 1000 / 100);
// }
// else {
//     System.Console.WriteLine("Третьей цифры нет");
// }
// Вариант №2

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 > 99)
{
    while(number1 >999)
    number1 /=10;

    System.Console.WriteLine(number1 % 10);
}
else {
    System.Console.WriteLine("Третьей цифры нет");
}
