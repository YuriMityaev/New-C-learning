// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[n];
// //int i = 0;

// //while (i< n)

// for (int i = 0; i < arr.Length; arr[i] = i ++)
// {
//     arr[i] = i + 1;
//     System.Console.Write($"{arr[i]}" + " ");
//     // i = i + 1;
// }

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = {3,6,7,3,1,3,6,6,43,4,5};

for (int i = 0; i < n; arr[i] = i ++)
{
    
    if (arr[i] % 2 == 0)
    
    {  
       
        System.Console.Write(arr[i] + " Чет ");
    }
    else
    {
        if (arr[i] %2 != 0)
        {
            System.Console.Write(arr[i] + "Нечет ");
        }
        
        
    }
     arr[i] = i + 1;
    // i = i + 1;
}
