int n = 5;
int[] array = { 4, 2, 9, 6, 7 };
int i = 0;
int max = array[0];
// while(i < n)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i = i +1;
// }
for (i = 0; i < n; i = i + 1)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine(max);