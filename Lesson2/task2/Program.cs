Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[n];
//int i = 0;

//while (i< n)
for(int i = 0; i < n; arr[i]= i + 1)
{
    arr[i] = i + 1; 
    System.Console.Write($"{arr[i]}" + " ");
   i = i + 1;
}