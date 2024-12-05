// начинаем работать с функциями.

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numinate = a * b;
//     double denomenator = c + d;
//     double result = numinate / denomenator;
//     return result;
// }

// double result = CalculateFormula(4, 4, 6, 6);

// System.Console.WriteLine(result);

//Задача 2.

// void PrintSquares (int limit)
// {
//     int i = 1;
//     while(i <= limit)
//     {
//         System.Console.Write($"{i*i} ");
//     i++;
//     }
// }
// System.Console.WriteLine("Please fill limit: ");
// PrintSquares(Convert.ToInt32(Console.ReadLine()));


// задача 3 Передача массива в функцию и последующее изменение.

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void printArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
printArray(array);
