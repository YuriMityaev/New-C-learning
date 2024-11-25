//int n = 5;
int[] array = { 4, 2, 9, 6, 7, 3, 34, 44};
// int i = 0;
int max = array[0];
// while (i < n)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i = i + 1;
// }
// System.Console.WriteLine(max);



// вариант 2
// max - array[0]; - обнуление макс до 1 значения массива
// for (int j = 0; j < n; j++)
// {
//     if (array[j] > max)
//     {
//         max = array[j];
//     }
// }

// System.Console.WriteLine(max);
foreach(int e in array)
{
    if (e>max)
{
    max = e;
}
}
System.Console.WriteLine(max);