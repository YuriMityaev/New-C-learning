
// string[] names = {"Nikita", "Nastya", "Egor"};

// names[0] = "New Name";
// System.Console.WriteLine(names[0]);

// Необходимо задать массив и написать программу 
// принимающую число и проверяющая если ли число в массиве.

// Способ 2


// int[]   array = new int[4];
// System.Console.WriteLine("Введите значения массива: ");
// for (int i = 0; i < array.Length; i++)

// {
//     System.Console.Write($"Введите {i}-й элемент массива:" );
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " " ); 
// }

// 3-й способ с рандомной генерацией + решение задачи.

// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 10);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }

// System.Console.WriteLine("\nВведите искомое число");
// int number = Convert.ToInt32(Console.ReadLine());

// bool numberIsFinded = false;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] == number)
//     {
//         numberIsFinded = true;
//         break;
//     }
// }
// if(numberIsFinded)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

// Задача: задать массив из 10 элеменотов, заполненный в промежутке [-10;10]
// заменим отрицательные на положительные и наоборот.

// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-10, 11);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }


// for(int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }
// System.Console.WriteLine();

// задача 4. СОздать массив и умножить его первое число на последние, предполследние на второе и тд.
// вывести визуально результат. 

//  System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-10, 11);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }

// int[] newArray = new int[array.Length / 2];

// for(int i=0; i < newArray.Length; i++)
// {
//     newArray[i] = array[i] * array[array.Length - 1 - i];
// }
// System.Console.WriteLine();

// for(int i=0; i < newArray.Length; i++)
// {
//     System.Console.Write(newArray[i] + " ");
// }

// Задача 5. ДАно трехнзначное число. Создайте массив фицр из числа.
// Младший разряд расположен на 0 индексе массива. старший на 2 индексе.

// int number = new Random().Next(100, 1000);
// System.Console.WriteLine("Сгенерированное число:" + number);

// int[] array = new int[3];

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = number % 10; 
//     number /= 10;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(array[i] + " ");
// }

// Генерация вещественного числа.
// Random rand = new Random();
// double number = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 3);
// System.Console.WriteLine("Сгенерированное число: " + number);
